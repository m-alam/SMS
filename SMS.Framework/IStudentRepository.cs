using SMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Framework
{
    public interface IStudentRepository : IRepository<Student, int, FrameworkContext>
    {
        //IList<Student> GetLatestStudents();
    }
}
