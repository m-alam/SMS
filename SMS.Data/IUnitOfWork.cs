using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Data
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
    }
}
