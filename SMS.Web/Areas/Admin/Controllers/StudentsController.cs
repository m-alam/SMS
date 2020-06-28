using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SMS.Web.Areas.Admin.Models;

namespace SMS.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentsController : Controller
    {      
        
        private readonly IConfiguration _configaration;
        public StudentsController(IConfiguration configuration)
        {
            _configaration = configuration;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<StudentModel>();
            return View(model);
        }
        public IActionResult AddStudent()
        {
            var model = new CreateStudentModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent([
            Bind(nameof(CreateStudentModel.Name),
            nameof(CreateStudentModel.Email),
            nameof(CreateStudentModel.Department))] CreateStudentModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();                    
                    return RedirectToAction("Index");
                }
                
                catch (Exception ex)
                {
                    //model.Response = new ResponseModel("Book creation failed.", ResponseType.Failure);
                }
            }
            return View(model);
        }

        public IActionResult GetStudents()
        {
            var tableModel = new DataTableAjaxRequestModels(Request);
            using var model = Startup.AutofacContainer.Resolve<StudentModel>();
            var data = model.GetStudents(tableModel);
            return Json(data);
        }
    }
}
