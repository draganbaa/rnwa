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
    public class MarksController : Controller
    {
        private Model2 db = new Model2();

        // GET: Marks
        public ActionResult Index()
        {
            var marks = db.marks.Include(m => m.students).Include(m => m.subjects);
            return View(marks.ToList());
        }

        // GET: Marks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            marks marks = db.marks.Find(id);
            if (marks == null)
            {
                return HttpNotFound();
            }
            return View(marks);
        }

        // GET: Marks/Create
        public ActionResult Create()
        {
            ViewBag.student_roll_num = new SelectList(db.students, "roll_num", "first_name");
            ViewBag.subject_id = new SelectList(db.subjects, "id", "name");
            return View();
        }

        // POST: Marks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,student_roll_num,subject_id,marks1")] marks marks)
        {
            if (ModelState.IsValid)
            {
                db.marks.Add(marks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.student_roll_num = new SelectList(db.students, "roll_num", "first_name", marks.student_roll_num);
            ViewBag.subject_id = new SelectList(db.subjects, "id", "name", marks.subject_id);
            return View(marks);
        }

        // GET: Marks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            marks marks = db.marks.Find(id);
            if (marks == null)
            {
                return HttpNotFound();
            }
            ViewBag.student_roll_num = new SelectList(db.students, "roll_num", "first_name", marks.student_roll_num);
            ViewBag.subject_id = new SelectList(db.subjects, "id", "name", marks.subject_id);
            return View(marks);
        }

        // POST: Marks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,student_roll_num,subject_id,marks1")] marks marks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.student_roll_num = new SelectList(db.students, "roll_num", "first_name", marks.student_roll_num);
            ViewBag.subject_id = new SelectList(db.subjects, "id", "name", marks.subject_id);
            return View(marks);
        }

        // GET: Marks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            marks marks = db.marks.Find(id);
            if (marks == null)
            {
                return HttpNotFound();
            }
            return View(marks);
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            marks marks = db.marks.Find(id);
            db.marks.Remove(marks);
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
