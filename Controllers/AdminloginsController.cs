using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoctorWeb.Models;

namespace DoctorWeb.Controllers
{
    public class AdminloginsController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();

        // GET: Adminlogins
        public ActionResult Index()
        {
            return View(db.Adminlogins.ToList());
        }

        // GET: Adminlogins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adminlogin adminlogin = db.Adminlogins.Find(id);
            if (adminlogin == null)
            {
                return HttpNotFound();
            }
            return View(adminlogin);
        }

        // GET: Adminlogins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adminlogins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdminId,AdminFirstName,AdminLastName,AdminEmail,AdminPassword,AdminConfirmPassword")] Adminlogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                db.Adminlogins.Add(adminlogin);
                db.SaveChanges();
                return RedirectToAction("adminloginpanel","AdminLog");
            }

            return View(adminlogin);
        }

        // GET: Adminlogins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adminlogin adminlogin = db.Adminlogins.Find(id);
            if (adminlogin == null)
            {
                return HttpNotFound();
            }
            return View(adminlogin);
        }

        // POST: Adminlogins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdminId,AdminFirstName,AdminLastName,AdminEmail,AdminPassword,AdminConfirmPassword")] Adminlogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminlogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminlogin);
        }

        // GET: Adminlogins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adminlogin adminlogin = db.Adminlogins.Find(id);
            if (adminlogin == null)
            {
                return HttpNotFound();
            }
            return View(adminlogin);
        }

        // POST: Adminlogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adminlogin adminlogin = db.Adminlogins.Find(id);
            db.Adminlogins.Remove(adminlogin);
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
