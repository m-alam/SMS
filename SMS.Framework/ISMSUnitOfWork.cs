using SMS.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Framework
{
    public interface ISMSUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
    }
}
