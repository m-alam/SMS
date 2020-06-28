using SMS.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Web.Areas.Admin.Models
{
    public class CreateStudentModel:StudentBaseModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public CreateStudentModel(IStudentService studentService)
            : base(studentService)
        {
        }
        public CreateStudentModel()
            : base()
        {
        }
        public void Create()
        {
            var student = new Student
            {
                Name = this.Name,
                Email = this.Email,
                Department = this.Department,
            };

            _studentService.CreateStudent(student);
            //ResponseModel = new ResponseModel("Book creation successful.", ResponseType.Success);
        }
    }
}
