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
    public class ViewBOController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();

        // GET: ViewBO
        public ActionResult Index()
        {
            return View(db.BookingOnlines.ToList());
        }

        // GET: ViewBO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingOnline bookingOnline = db.BookingOnlines.Find(id);
            if (bookingOnline == null)
            {
                return HttpNotFound();
            }
            return View(bookingOnline);
        }

        // GET: ViewBO/Create
        public ActionResult Create()
        {
            var list = new List<string>() { "Physicians", "Neurologists", "Cardiologist", "Seurgon", "Psychiatrists", "Dental" };
            ViewBag.list = list;
            return View();
            
        }

        // POST: ViewBO/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bo_id,bo_name,bo_phone,bo_date,bo_time,bo_Speciality")] BookingOnline bookingOnline)
        {
            if (ModelState.IsValid)
            {
                db.BookingOnlines.Add(bookingOnline);
                db.SaveChanges();
                 return RedirectToAction("Index","DoctorRegistrationForm");
               // ViewBag.msg = "Booking has done";
            }

            return View(bookingOnline);
        }

        // GET: ViewBO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingOnline bookingOnline = db.BookingOnlines.Find(id);
            if (bookingOnline == null)
            {
                return HttpNotFound();
            }
            return View(bookingOnline);
        }

        // POST: ViewBO/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "bo_id,bo_name,bo_phone,bo_date,bo_time,bo_Speciality")] BookingOnline bookingOnline)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingOnline).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingOnline);
        }

        // GET: ViewBO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingOnline bookingOnline = db.BookingOnlines.Find(id);
            if (bookingOnline == null)
            {
                return HttpNotFound();
            }
            return View(bookingOnline);
        }

        // POST: ViewBO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookingOnline bookingOnline = db.BookingOnlines.Find(id);
            db.BookingOnlines.Remove(bookingOnline);
            db.SaveChanges();
             return RedirectToAction("Index","ViewBO");
            //return Request.CreateResponse(HttpStatusCode.OK);
        }

        public ActionResult Test()
        {
            var list = new List<string>() { "Physicians", "Neurologists", "Cardiologist", "Seurgon", "Psychiatrists", "Dental" };
            ViewBag.list = list;
            return View();
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
