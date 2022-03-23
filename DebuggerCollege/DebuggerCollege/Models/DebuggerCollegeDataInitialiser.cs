using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DebuggerCollege.Models
{
    public class DebuggerCollegeDataInitialiser : DropCreateDatabaseAlways<CoursesContext>
    {
         protected override void Seed(CoursesContext context)
        {
            DebuggerCollege.Models.Courses con1 = new DebuggerCollege.Models.Courses();
            con1.id = 1;
            con1.CourseName = "Computer Science";
            context.Courses.Add(con1);

            DebuggerCollege.Models.Courses con2 = new DebuggerCollege.Models.Courses();
            con2.id = 2;
            con2.CourseName = "Software Engineering";
            context.Courses.Add(con2);

            DebuggerCollege.Models.Courses con3 = new DebuggerCollege.Models.Courses();
            con3.id = 3;
            con3.CourseName = "Cyber Security";
            context.Couses.Add(con3);

            //.........................................................................

            DebuggerCollege.Models.Modules Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 1903; // might have toi change id to a string as it contains letters COS1903
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Scala Programming";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 1920; // might have toi change id to a string as it contains letters COS1920
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Database Management";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            DebuggerCollege.Models.Modules Module2 = new DebuggerCollege.Models.Modules();
            Module2.id = 3906; // might have toi change id to a string as it contains letters SE3906
            Module2.CourseId = 2; //Software Engineering
            Module2.ModuleTitle = "Interaction Design";
            Module2.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module2);

            DebuggerCollege.Models.Modules Module3 = new DebuggerCollege.Models.Modules();
            Module3.id = 3901; // might have toi change id to a string as it contains letters SE3906
            Module3.CourseId = 3; //Cyber Security
            Module3.ModuleTitle = "C Programming";
            Module3.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module3);

            //asdasdashdaofs
        }
    


    }
}