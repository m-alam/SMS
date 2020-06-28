using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Framework
{
    public interface IStudentService : IDisposable
    {
        (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText);
        void CreateStudent(Student student);
    }
}
