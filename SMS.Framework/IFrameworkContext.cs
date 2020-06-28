using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Framework
{
    public interface IFrameworkContext
    {
        DbSet<Student> Students { get; set; }
    }
}
