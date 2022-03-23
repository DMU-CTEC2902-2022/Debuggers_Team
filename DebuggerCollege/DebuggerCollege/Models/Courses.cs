using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DebuggerCollege.Models
{
    public class Courses
    {
        public virtual int id { get; set; }
        public virtual string CourseName { get; set; }
        public virtual string CourseInformation { get; set; }
    }
}