using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DebuggerCollege.Models
{
    public class Student
    {
        public virtual string FullName { get; set; }
        public virtual int PhoneNo { get; set; }
        public virtual string Email { get; set; }
        public virtual Courses courses { get; set; }
    }
}