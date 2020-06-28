using SMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Framework
{
    public class StudentRepository : Repository<Student, int, FrameworkContext>, IStudentRepository
    {
        public StudentRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }

    }
}
