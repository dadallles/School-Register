using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolRegister.BLL.Entities;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.ViewModels.DTOs;

namespace SchoolRegister.Web.Controllers
{
    public class EmailController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;
        private readonly UserManager<User> _userManager;

        public EmailController(ITeacherService teacherService, IStudentService studentService, UserManager<User> userManager)
        {
            _userManager = userManager;
            _studentService = studentService;
            _teacherService = teacherService;
        }

        [Authorize(Roles = "Teacher")]
        public IActionResult SendEmailToParent()
        {
            var user = _userManager.GetUserAsync(User).Result;
            @ViewBag.SenderId = user.Id;

            var studentsVm = _studentService.GetStudents();
            ViewBag.StudentsSelectList = new SelectList(studentsVm.Select(t => new
                {
                    Text = $"{t.FirstName} {t.LastName}",
                    Value = t.Id
                })
                , "Value", "Text");

            return View();
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendEmailToParent(SendEmailToParentDto sendEmailToParentDto)
        {
            if (ModelState.IsValid)
            {
                _teacherService.SendEmailToParent(sendEmailToParentDto);
                return RedirectToAction("SendEmailToParent");
            }

            return View();
        }
    }
}