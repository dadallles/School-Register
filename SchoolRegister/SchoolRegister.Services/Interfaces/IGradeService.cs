using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SchoolRegister.BLL.Entities;
using SchoolRegister.ViewModels.DTOs;
using SchoolRegister.ViewModels.VMs;

namespace SchoolRegister.Services.Interfaces
{
    public interface IGradeService
    {
        GradeVm AddGradeToStudent(AddGradeToStudentDto addGradeToStudentDto);
        GradesReportVm GetGradesReportForStudent(GetGradesDto getGradesDto);
        IEnumerable<GradeVm> GetGrades(Expression<Func<Grade, bool>> filterPredicate = null);
    }
}
