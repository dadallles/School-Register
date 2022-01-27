using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.ViewModels.DTOs
{
   public class AttachDetachStudentToGroupDto
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int GroupId { get; set; }
    }
}
