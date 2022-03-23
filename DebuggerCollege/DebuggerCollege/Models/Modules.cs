using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DebuggerCollege.Models
{
    public class Modules
    {
        public virtual int id { get; set; }
        public virtual int CourseId { get; set; }
        public virtual string ModuleTitle { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleContents { get; set; }
        public virtual Courses courses { get; set; }
    }
}