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
    public class DoctorRegistrationFormController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();

        // GET: DoctorRegistrationForm
        public ActionResult Index(string searchstring,string loc)
        {
            return View(db.Registration_Forms.Where(x => (x.R_Specialization.Contains(searchstring) && x.R_State.Contains(loc))));
            //var doctors = from a in db.Registration_Forms
            //              select a;

            //if (!string.IsNullOrEmpty(searchstring))
            //{ 
            //    doctors = doctors.Where(s => s.R_Specialization.Contains(searchstring));
            //}
            //return View(doctors);
        }
        public ActionResult DIndex()
        {
            return View(db.Registration_Forms.ToList());
        }



          

        // GET: DoctorRegistrationForm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registration_Form registration_Form = db.Registration_Forms.Find(id);
            if (registration_Form == null)
            {
                return HttpNotFound();
            }
            return View(registration_Form);
        }

        // GET: DoctorRegistrationForm/Create
        public ActionResult Create()
        {

            ViewBag.rid = new SelectList(db.Registration_Forms, "rid", "rid");
            var mn = new SelectList(db.Registration_Forms, "R_State", "R_State");
            ViewBag.R_State = mn;
            var spec = new SelectList(db.Registration_Forms, "R_Specialization", "R_Specialization");
            ViewBag.R_Specialization = spec;

            var list = new List<string>() { "Physicians", "Neurologists", "Cardiologist", "Seurgon", "Psychiatrists", "Dental" };
            ViewBag.list = list;

            var list1 = new List<string>() { "India", "USA" };
            ViewBag.list1 = list1;

            var list2 = new List<string>() { "MP", "Rajastan", "TamilNadu", "Bihar", "Maharastra", "UP","LosAngles","Tacoma" };
            ViewBag.list2 = list2;

            var list3 = new List<string>() { "Bhopal", "Indore", "Patna", "Jaipur", "Chennai", "Pune", "Nagpur", "Noidda", "Nagpur", "California", "Washigton" };
            ViewBag.list3 = list3;
            return View();
        }

        // POST: DoctorRegistrationForm/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rid,R_FirstName,R_LastName,R_Gender,R_Country,R_State,R_City,R_Contact,R_Email,R_Address,R_Fields,R_Qualification,R_Specialization,R_WorkExperience,R_AchievementDetails,R_Password,R_ConfirmPassword,R_ProfileStates,R_JoiningDate,R_OtherDetails")] Registration_Form registration_Form)
        {
            if (ModelState.IsValid)
            {
                db.Registration_Forms.Add(registration_Form);
                db.SaveChanges();
                return RedirectToAction("DLogin","DoctorLogin");
            }

            return View(registration_Form);
        }

        // GET: DoctorRegistrationForm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registration_Form registration_Form = db.Registration_Forms.Find(id);
            if (registration_Form == null)
            {
                return HttpNotFound();
            }
            return View(registration_Form);
        }

        // POST: DoctorRegistrationForm/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rid,R_FirstName,R_LastName,R_Gender,R_Country,R_State,R_City,R_Contact,R_Email,R_Address,R_Fields,R_Qualification,R_Specialization,R_WorkExperience,R_AchievementDetails,R_Password,R_ConfirmPassword,R_ProfileStates,R_JoiningDate,R_OtherDetails")] Registration_Form registration_Form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registration_Form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registration_Form);
        }

        // GET: DoctorRegistrationForm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registration_Form registration_Form = db.Registration_Forms.Find(id);
            if (registration_Form == null)
            {
                return HttpNotFound();
            }
            return View(registration_Form);
        }

        // POST: DoctorRegistrationForm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registration_Form registration_Form = db.Registration_Forms.Find(id);
            db.Registration_Forms.Remove(registration_Form);
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
