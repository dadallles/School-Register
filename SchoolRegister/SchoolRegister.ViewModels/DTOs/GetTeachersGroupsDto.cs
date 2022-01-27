using System;
using System.Linq.Expressions;
using SchoolRegister.BLL.Entities;

namespace SchoolRegister.ViewModels.DTOs
{
    public class GetTeachersGroupsDto
    {
        public int TeacherId { get; set; }

        public Expression<Func<Student, bool>> GroupsFilterPredicate { get; set; }
    }
}
