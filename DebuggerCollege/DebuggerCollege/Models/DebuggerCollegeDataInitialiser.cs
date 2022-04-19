using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DebuggerCollege.Data;

namespace DebuggerCollege.Models
{
    public class DebuggerCollegeDataInitialiser : System.Data.Entity.DropCreateDatabaseAlways<Data.CoursesContext>
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
            context.Courses.Add(con3);

            //.........................................................................

            DebuggerCollege.Models.Modules Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 1903; // might have toi change id to a string as it contains letters COS1903
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Scala Programming";
            Module1.ModuleDescription = "Write programs that effectively use parallel collections to achieve performance." +
                " Manipulate data with Spark and Scala";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 1920; // might have toi change id to a string as it contains letters COS1920
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Database Management";
            Module1.ModuleDescription = "Concepts and theory of relational database management systems (RDBMS)" +
                " including the analysis and design of relational database systems. This is a project-based class.";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 2905; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Object Oriented Programming";
            Module1.ModuleDescription = "This module covers the development of simple software systems." +
                "Students will gain an understanding of the software development process," +
                " and learn to design and implement applications in a popular object-oriented programming language.";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 2910; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Database Management 2";
            Module1.ModuleDescription = "To provide students with the ability to independently and as a team member identify, analyse, " +
                "discuss and report key issues of ethics and law that relate to computer security for both individuals and society." +
                " Students will also be provided with an opportunity to explore and understand the importance of the role’s users play in cyber security";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3911; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Mobile Application";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3611; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Computer Ethics and Privacy";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3451; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 1; //Computer Science 
            Module1.ModuleTitle = "Development Project";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            //DebuggerCollege.Models.Modules Module2 = new DebuggerCollege.Models.Modules();
            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3906; // might have toi change id to a string as it contains letters SE3906
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Interaction Design";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3410; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Web Application Penetration Testing";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3406; // might have toi change id to a string as it contains letters
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Fuzzy Logic and Knowledge Based Systems";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3613; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Data Mining";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3614; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Big Data and Business Models";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3611; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Computer Ethics and Privacy";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3611; // might have toi change id to a string as it contains letters 
            Module1.CourseId = 2; //Software Engineering
            Module1.ModuleTitle = "Development Project";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            //DebuggerCollege.Models.Modules Module3 = new DebuggerCollege.Models.Modules();
            Module1 = new DebuggerCollege.Models.Modules();
            Module1.id = 3901; // might have toi change id to a string as it contains letters SE3906
            Module1.CourseId = 3; //Cyber Security
            Module1.ModuleTitle = "C Programming";
            Module1.ModuleDescription = "dfgdfgfdgfd";
            //Module1.ModuleContents =
            context.Modules.Add(Module1);

            //asdasdashdaofs
        }
    


    }
}