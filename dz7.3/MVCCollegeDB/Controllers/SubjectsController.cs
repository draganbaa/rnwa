using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCollegeDB.Models;

namespace MVCCollegeDB.Controllers
{
    public class SubjectsController : Controller
    {
        private Model2 db = new Model2();

        // GET: Subjects
        public ActionResult Index()
        {
            var subjects = db.subjects.Include(s => s.departments).Include(s => s.faculty);
            return View(subjects.ToList());
        }

        // GET: Subjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subjects subjects = db.subjects.Find(id);
            if (subjects == null)
            {
                return HttpNotFound();
            }
            return View(subjects);
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            ViewBag.department_id = new SelectList(db.departments, "id", "name");
            ViewBag.faculty_id = new SelectList(db.faculty, "id", "first_name");
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,department_id,start_date,end_date,name,faculty_id")] subjects subjects)
        {
            if (ModelState.IsValid)
            {
                db.subjects.Add(subjects);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.department_id = new SelectList(db.departments, "id", "name", subjects.department_id);
            ViewBag.faculty_id = new SelectList(db.faculty, "id", "first_name", subjects.faculty_id);
            return View(subjects);
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subjects subjects = db.subjects.Find(id);
            if (subjects == null)
            {
                return HttpNotFound();
            }
            ViewBag.department_id = new SelectList(db.departments, "id", "name", subjects.department_id);
            ViewBag.faculty_id = new SelectList(db.faculty, "id", "first_name", subjects.faculty_id);
            return View(subjects);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,department_id,start_date,end_date,name,faculty_id")] subjects subjects)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjects).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.department_id = new SelectList(db.departments, "id", "name", subjects.department_id);
            ViewBag.faculty_id = new SelectList(db.faculty, "id", "first_name", subjects.faculty_id);
            return View(subjects);
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subjects subjects = db.subjects.Find(id);
            if (subjects == null)
            {
                return HttpNotFound();
            }
            return View(subjects);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            subjects subjects = db.subjects.Find(id);
            db.subjects.Remove(subjects);
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
