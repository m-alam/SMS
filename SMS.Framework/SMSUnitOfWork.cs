using SMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Framework
{
    public class SMSUnitOfWork : UnitOfWork, ISMSUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public SMSUnitOfWork(FrameworkContext context, IStudentRepository studentRepository)
            : base(context)
        {

            StudentRepository = studentRepository;
        }
    }
}
