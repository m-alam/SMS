using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
