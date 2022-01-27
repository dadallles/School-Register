using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SchoolRegister.BLL.Entities;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.ViewModels.DTOs;

namespace SchoolRegister.Web.Controllers
{
    public class GroupController : BaseController<GroupController>
    {
        private readonly IStudentService _studentService;
        private readonly IGroupService _groupService;
        private readonly UserManager<User> _userManager;

        public GroupController(IStudentService studentService, IGroupService groupService, UserManager<User> userManager, IStringLocalizer<GroupController> localizer, ILoggerFactory loggerFactory) 
            : base(localizer, loggerFactory)
        {
            _studentService = studentService;
            _userManager = userManager;
            _groupService = groupService;
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult Index()
        {
            return View(_groupService.GetGroups());
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult AddOrUpdateGroup(int? id = null)
        {
            if (id.HasValue)
            {
                var groupVm = _groupService.GetGroup(x => x.Id == id);
                ViewBag.ActionType = _localizer["Edit"];
                return View(Mapper.Map<AddOrUpdateGroupDto>(groupVm));
            }

            ViewBag.ActionType = _localizer["Add"];

            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrUpdateGroup(AddOrUpdateGroupDto addOrUpdateGroupDto)
        {
            if (ModelState.IsValid)
            {
                _groupService.AddOrUpdateGroup(addOrUpdateGroupDto);
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult RemoveGroup(int id)
        {
            var groupVm = _groupService.GetGroup(x => x.Id == id);
            return View(groupVm);
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveGroup(int? id = null)
        {
            if (id != null)
            {
                _groupService.Remove(id);
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult AttachStudentToGroup(int id)
        {
            var groupVms = _groupService.GetGroups();

            ViewBag.GroupsSelectList = new SelectList(groupVms.Select(t => new
                {
                    Text = $"{t.Name}",
                    Value = t.Id
                })
                , "Value", "Text");

            ViewBag.StudentId = id;

            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AttachStudentToGroup(AttachDetachStudentToGroupDto attachStudentToGroup)
        {
            if (ModelState.IsValid)
            {
                _groupService.AttachStudentToGroup(attachStudentToGroup);
                return RedirectToAction("ViewStudents", "Student");
            }

            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult DetachStudentFromGroup(int id)
        {
            var studentVm = _studentService.GetStudent(x => x.Id == id);
            var groupVm = _groupService.GetGroup(x => x.Name == studentVm.GroupName);

            ViewBag.studentId = studentVm.Id;
            ViewBag.groupId = groupVm.Id;
            ViewBag.studentName = studentVm.FirstName + " " + studentVm.LastName;
            ViewBag.groupName = groupVm.Name;

            return View(Mapper.Map<AttachDetachStudentToGroupDto>(groupVm));
        }


        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DetachStudentFromGroup(AttachDetachStudentToGroupDto attachDetachStudentToGroup)
        {
            if (ModelState.IsValid)
            {
                _groupService.DetachStudentFromGroup(attachDetachStudentToGroup);
                return RedirectToAction("ViewStudents", "Student");
            }

            return View();
        } 
    }
}