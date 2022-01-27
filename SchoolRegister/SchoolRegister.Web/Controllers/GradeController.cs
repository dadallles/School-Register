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
    public class GradeController : Controller
    {
        private readonly IGradeService _gradeService;
        private readonly ISubjectService _subjectService;
        private readonly IStudentService _studentService;
        private readonly UserManager<User> _userManager;

        public GradeController(IGradeService gradeService, ISubjectService subjectService, IStudentService studentService, UserManager<User> userManager)
        {
            _gradeService = gradeService;
            _subjectService = subjectService;
            _studentService = studentService;
            _userManager = userManager;
        }

        [Authorize(Roles = "Teacher")]
        public IActionResult AddGradeToStudent()
        {
            var user = _userManager.GetUserAsync(User).Result;

            var subjectsVm = _subjectService.GetSubjects(x => x.TeacherId == user.Id);
            ViewBag.SubjectsSelectList = new SelectList(subjectsVm.Select(t => new
                {
                    Text = $"{t.Name}",
                    Value = t.Id
                })
                , "Value", "Text");

            var studentsVm = _studentService.GetStudents();
            ViewBag.StudentsSelectList = new SelectList(studentsVm.Select(t => new
                {
                    Text = $"{t.FirstName} {t.LastName}",
                    Value = t.Id
                })
                , "Value", "Text");

            ViewBag.TeacherId = user.Id;

            return View();
        }

        [Authorize(Roles = "Teacher")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGradeToStudent(AddGradeToStudentDto addGradeToStudentDto)
        {
            if (ModelState.IsValid)
            {
                _gradeService.AddGradeToStudent(addGradeToStudentDto);
                return RedirectToAction("AddGradeToStudent");
            }

            return View();
        }

        [Authorize(Roles = "Student, Parent")]
        public IActionResult ViewGrades(int? id)
        {
            var user = _userManager.GetUserAsync(User).Result;

            if (_userManager.IsInRoleAsync(user, "Student").Result)
            {
                return View(_gradeService.GetGrades(x=>x.StudentId == user.Id));
            }

            var gradesVms = _gradeService.GetGrades(x => x.StudentId == id);

            return View(gradesVms);


        }
    }
}