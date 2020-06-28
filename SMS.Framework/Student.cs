using SMS.Data;
using System;

namespace SMS.Framework
{
    public class Student: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
