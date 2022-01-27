using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolRegister.BLL.Entities;
using SchoolRegister.Services.Interfaces;
using SchoolRegister.Web.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SchoolRegister.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly UserManager<User> _userManager;

        public StudentController(IStudentService studentService, UserManager<User> userManager)
        {
            _studentService = studentService;
            _userManager = userManager;
        }

        [Authorize(Roles = "Parent")]
        public IActionResult ViewStudentOfParent()
        {
            var user = _userManager.GetUserAsync(User).Result;
            var studentVms = _studentService.GetStudents(x => x.ParentId == user.Id);

            return View(studentVms);
        }

        [Authorize(Roles = "Admin, Teacher")]
        public IActionResult ViewStudents(string filterValue = null)
        {
            Expression<Func<Student, bool>> filterPredicate = null;
            if (!string.IsNullOrWhiteSpace(filterValue))
            {
                filterPredicate = x => x.UserName.Contains(filterValue);
            }

            bool isAjax = HttpContext.Request.Headers["x-requested-width"] == "XMLHttpRequest";
            var user = _userManager.GetUserAsync(User).Result;

            if (_userManager.IsInRoleAsync(user, "Admin").Result)
            {
                var studentsVm = _studentService.GetStudents(filterPredicate);
                if (isAjax)
                {
                    return PartialView("_StudentsTableDataPartial", studentsVm);
                }

                return View(studentsVm);
            }
            else if (_userManager.IsInRoleAsync(user, "Teacher").Result)
            {
                var filterTeacher = _userManager.GetUserAsync(User).Result as Teacher;
                Expression<Func<Student, bool>> filterStudent = y => y.Id == filterTeacher.Id;
                var finalExpression = filterPredicate != null ?
                    Expression.Lambda<Func<Student, bool>>(
                        Expression.AndAlso(filterPredicate.Body, new ExpressionParameterReplacer(filterStudent.Parameters, filterPredicate.Parameters)
                                  .Visit(filterStudent.Body)
                        ), filterPredicate.Parameters)
                    : filterStudent;
                var studentsVm = _studentService.GetStudents(finalExpression);

                if (isAjax)
                {
                    return PartialView("_StudentsTableDataPartial", studentsVm);
                }

                return View(studentsVm);
            }
            else if (_userManager.IsInRoleAsync(user, "Student").Result)
            {
                return RedirectToAction("Details", "Student", new { studentId = user.Id });
            }
            else
            {
                return View("Error");
            }
        }




    }
}