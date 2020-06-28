using Autofac;
using SMS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Web.Areas.Admin.Models
{
    public class StudentBaseModel: AdminBaseModel, IDisposable
    {
        protected readonly IStudentService _studentService;
        public StudentBaseModel(IStudentService studentService)
        {

            _studentService = studentService;
        }
        public StudentBaseModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }
        public void Dispose()
        {
            _studentService?.Dispose();
        }
    }
}
