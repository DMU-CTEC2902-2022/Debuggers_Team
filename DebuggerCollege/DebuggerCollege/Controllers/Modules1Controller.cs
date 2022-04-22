using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DebuggerCollege.Data;
using DebuggerCollege.Models;

namespace DebuggerCollege.Controllers
{
    public class Modules1Controller : Controller
    {
        private CoursesContext db = new CoursesContext();

        // GET: Modules1
        public ActionResult Index(int? id)
        {
            List<Modules> moduleslist;
            var models = db.Modules.Include(g => g.courses);
            if (id != null)
                moduleslist = models.ToList().FindAll(p => p.CourseId == id); 
            // retrieve all models for id 
          else moduleslist = models.ToList(); // Retrieve all games
            if (moduleslist.Count() == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(moduleslist);
        }

        // GET: Modules1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modules modules = db.Modules.Find(id);
            if (modules == null)
            {
                return HttpNotFound();
            }
            return View(modules);
        }

        // GET: Modules1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modules1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,CourseId,ModuleTitle,ModuleDescription,ModuleContents")] Modules modules)
        {
            if (ModelState.IsValid)
            {
                db.Modules.Add(modules);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modules);
        }

        // GET: Modules1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modules modules = db.Modules.Find(id);
            if (modules == null)
            {
                return HttpNotFound();
            }
            return View(modules);
        }

        // POST: Modules1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,CourseId,ModuleTitle,ModuleDescription,ModuleContents")] Modules modules)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modules).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modules);
        }

        // GET: Modules1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modules modules = db.Modules.Find(id);
            if (modules == null)
            {
                return HttpNotFound();
            }
            return View(modules);
        }

        // POST: Modules1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Modules modules = db.Modules.Find(id);
            db.Modules.Remove(modules);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
