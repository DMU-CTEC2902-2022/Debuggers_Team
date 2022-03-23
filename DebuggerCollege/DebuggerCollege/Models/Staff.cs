using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DebuggerCollege.Models
{
    public class Staff
    {
        public virtual int id { get; set; }
        public virtual int ModuleId { get; set; }
        public virtual string CourseName { get; set; }
        public virtual Modules modules { get; set; }
    }
}