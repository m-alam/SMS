using SMS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Web.Areas.Admin.Models
{
    public class StudentModel:StudentBaseModel
    {
        public StudentModel(IStudentService studentService)
            : base(studentService)
        {
        }
        public StudentModel()
            : base()
        {
        }
        internal object GetStudents(DataTableAjaxRequestModels tableModel)
        {

            var data = _studentService.GetStudents
                (
                    tableModel.PageIndex,
                    tableModel.PageSize,
                    tableModel.SearchText,
                    tableModel.GetSortText(new string[] { "Name", "Email", "Department" })
                );
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[] {

                    record.Name,
                    record.Email,
                    record.Department,
                    record.Id.ToString()
                    }
                ).ToArray()
            };
        }
        //internal string Delete(int id)
        //{
        //    var deletedBook = _bookService.DeleteBook(id);
        //    return deletedBook.Title;
        //}
    }
}
