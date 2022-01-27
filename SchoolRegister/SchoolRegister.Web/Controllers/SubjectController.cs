using System;
using System.Linq;
using System.Linq.Expressions;
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
using SchoolRegister.Web.Extensions;

namespace SchoolRegister.Web.Controllers
{
    public class SubjectController : BaseController<SubjectController>
    {
        private readonly ISubjectService _subjectService;
        private readonly ITeacherService _teacherService;
        private readonly UserManager<User> _userManager;

        public SubjectController(ISubjectService subjectService, ITeacherService teacherService, UserManager<User> userManager, IStringLocalizer<SubjectController> localizer, ILoggerFactory loggerFactory) 
            : base(localizer, loggerFactory)
        {
            _subjectService = subjectService;
            _teacherService = teacherService;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult Index(string filterValue = null)
        {
            Expression<Func<Subject, bool>> filterPredicate = null;
            if(!string.IsNullOrWhiteSpace(filterValue))
            {
                filterPredicate = x => x.Name.Contains(filterValue);
            }

            bool isAjax = HttpContext.Request.Headers["x-requested-width"] == "XMLHttpRequest";
            var user = _userManager.GetUserAsync(User).Result;

            if (_userManager.IsInRoleAsync(user, "Admin").Result )
            {
                var subjectsVm = _subjectService.GetSubjects(filterPredicate);
                if(isAjax)
                {
                    return PartialView("_SubjectsTableDataPartial", subjectsVm);
                }

                return View(subjectsVm);
            }
            else if(_userManager.IsInRoleAsync(user, "Teacher").Result)
            {
                var teacher = _userManager.GetUserAsync(User).Result as Teacher;
                Expression<Func<Subject, bool>> filterTeacher = x => x.TeacherId == teacher.Id;
                var finalExpression = filterPredicate != null ?
                    Expression.Lambda<Func<Subject, bool>>(
                        Expression.AndAlso(filterPredicate.Body, new ExpressionParameterReplacer(filterTeacher.Parameters, filterPredicate.Parameters)
                                  .Visit(filterTeacher.Body)
                        ), filterPredicate.Parameters)
                    : filterTeacher;
                var subjectsVm = _subjectService.GetSubjects(finalExpression);

                if (isAjax)
                {
                    return PartialView("_SubjectsTableDataPartial", subjectsVm);
                }

                return View(subjectsVm);
            }
            else if(_userManager.IsInRoleAsync(user, "Student").Result)
            {
                return RedirectToAction("Details", "Student", new { studentId = user.Id });
            }
            else
            {
                return View("Error");
            }
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpGet]
        public IActionResult AddOrEditSubject(int? id = null)
        {
            var teachersVm = _teacherService.GetTeachers();
            ViewBag.TeachersSelectList = new SelectList(teachersVm.Select(t => new
                {
                    Text = $"{t.FirstName} {t.LastName}",
                    Value = t.Id
                })
                , "Value", "Text");

            if (id.HasValue)
            {
                var subjectVm = _subjectService.GetSubject(x => x.Id == id);
                ViewBag.ActionType = _localizer["Edit"];
                return View(Mapper.Map<AddOrUpdateSubjectDto>(subjectVm));
            }

            ViewBag.ActionType = _localizer["Add"];
            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditSubject(AddOrUpdateSubjectDto addOrUpdateSubjectDto)
        {
            if (ModelState.IsValid)
            {
                _subjectService.AddOrUpdate(addOrUpdateSubjectDto);
                return RedirectToAction("Index");
            }

            return View();
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult Details(int id)
        {
            var subjectVm = _subjectService.GetSubject(x => x.Id == id);
            return View(subjectVm);
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult RemoveSubject(int id)
        {
            var subjectVm = _subjectService.GetSubject(x => x.Id == id);
            return View(subjectVm);
        }

        [Authorize(Roles = "Admin, Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveSubject(int? id = null)
        {
            if (id != null)
            {
                _subjectService.Remove(id);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}