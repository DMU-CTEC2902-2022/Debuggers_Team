using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DebuggerCollege.Models;

namespace DebuggerCollege.Controllers
{
    public class SoftwareEngineeringController : Controller
    {
        // GET: SoftwareEngineering
        public ViewResult Modules()
        {
            //SoftwareEngineering Modules0
            SoftwareEngineering SEModel = new SoftwareEngineering();
            SEModel.ModuleCode = "SE390";
            SEModel.ModuleTitle = "Interaction Design.";
            SEModel.ModuleDescription = "Interaction design focuses on creating engaging interfaces with well thought out behaviors. Understanding how users and technology communicate with each other is fundamental to this field. With this understanding, you can anticipate how someone might interact with the system, fix problems early, as well as invent new ways of doing things. ";
            SEModel.ModuleContents = "Fundamentals";
            SEModel.StaffMembers = "Dr.Smith, Dr.Micheal, Dr.Nick.";

            //SoftwareEngineering Modules1
            SoftwareEngineering SEModel1 = new SoftwareEngineering();
            SEModel.ModuleCode1 = "SE3410";
            SEModel.ModuleTitle1 = "Web Application Penetration Testing.";
            SEModel.ModuleDescription1 = "Web application penetration testing works by using manual or automated penetration tests to identify any vulnerability, security flaws or threats in a web application. The tests involve using/implementing any of the known malicious penetration attacks on the application. The penetration tester exhibits/fabricates attacks and environment from an attacker’s perspective, such as using SQL injection tests. The web application penetration testing key outcome is to identify security weakness across the entire web application and its components (source code, database, back-end network). It also helps in prioritizing the identified vulnerabilities and threats, and possible ways to mitigate them.";
            SEModel.ModuleContents1 = "Risks";
            SEModel.StaffMembers1 = "Dr.Sandra, Dr.Jonathen, Dr.Natasha.";

            //SoftwareEngineering Modules2
            SoftwareEngineering SEModel2 = new SoftwareEngineering();
            SEModel.ModuleCode2 = "SE3406";
            SEModel.ModuleTitle2 = "Fuzzy Logic & Knowledge Based Systems.";
            SEModel.ModuleDescription2 = "Fuzzy logic is a form of many-valued logic in which the truth value of variables may be any real number between 0 and 1. It is employed to handle the concept of partial truth, where the truth value may range between completely true and completely false. By contrast, in Boolean logic, the truth values of variables may only be the integer values 0 or 1";
            SEModel.ModuleContents2 = "Base of fuzzy logic.";
            SEModel.StaffMembers2 = "Dr.Smith, Dr.Mathew, Dr.Mohammed.";

            //SoftwareEngineering Modules3
            SoftwareEngineering SEModel3 = new SoftwareEngineering();
            SEModel.ModuleCode3 = "SE3613";
            SEModel.ModuleTitle3 = "Data Mining.";
            SEModel.ModuleDescription3 = " Data mining is the process of sorting through large data sets to identify patterns and relationships that can help solve business problems through data analysis. Data mining techniques and tools enable enterprises to predict future trends and make more-informed business decisions.";
            SEModel.ModuleContents3 = "Data Minning on a bigger scale.";
            SEModel.StaffMembers3 = "Dr.Safe, Dr. lee, Dr. Wong";

            //SoftwareEngineering Modules4
            SoftwareEngineering SEModel4 = new SoftwareEngineering();
            SEModel.ModuleCode4 = "SE3614";
            SEModel.ModuleTitle4 = "Big Data & Business Models";
            SEModel.ModuleDescription4 = "The concept of a data-driven business model (DDBM) is built around data as a product – it lays out benefits for users of data-based services and introduces methods for managing (i.e. promoting, pricing, sale and delivery) of such products";
            SEModel.ModuleContents4 = "Data and Obversation";
            SEModel.StaffMembers4 = "Dr.Raven, Dr.Wotong, Dr. Einstien.";

            //SoftwareEngineering Modules5
            SoftwareEngineering SEModel5 = new SoftwareEngineering();
            SEModel.ModuleCode5 = "IMAT3611";
            SEModel.ModuleTitle5 = "Computer Ethics and Privacy.";
            SEModel.ModuleDescription5 = "Privacy, trust and security are closely intertwined, as are law and ethics. Privacy preservation and security provisions rely on trust (e.g., one will allow only those whom one trusts to enter one’s zone of inaccessibility; one will not feel secure unless one trusts the security provider). Violation of privacy constitutes a risk, thus, a threat to security. Law provides a resolution when ethics cannot (e.g., ethics knows that stealing is wrong; the law punishes thieves); ethics can provide context to law (e.g., law allows trading for the purpose of making a profit, but ethics provides input into ensuring trade is conducted fairly). Privacy breaches disturb trust and run the risk of diluting or losing security; it is a show of disrespect to the law and a violation of ethical principles.";
            SEModel.ModuleContents5 = "reglutions of Ethics and Privacy.";
            SEModel.StaffMembers5 = "Dr.Messi, Dr.Neymar, Dr.Ramos.";

            //SoftwareEngineering Modules6
            SoftwareEngineering SEModel6 = new SoftwareEngineering();
            SEModel.ModuleCode6 = "SE3451";
            SEModel.ModuleTitle6 = "Development Project.";
            SEModel.ModuleDescription6 = "When completing projects, it's useful to develop a detailed outline. Using an efficient project development plan to create your outline can help you track your team's budget, deadline and goals for a project. If your position requires you to plan projects, understanding the project development process can help you plan and organize successful projects. In this article, we discuss what project development is, explain the steps it involves and offer a list of tips to help you as you create a project development plan.";
            SEModel.ModuleContents6 = "Team development ptoject";
            SEModel.StaffMembers6 = "Dr.Mount, Dr.Silva, Dr.Kante";
            return View(SEModel);
        
        }
    }
}