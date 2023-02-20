using DoctorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorWeb.Controllers
{
    public class DoctorLoginController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();
        // GET: DoctorLogin
        public ActionResult Index()
        {
            return View(db.Registration_Forms.ToList());
        }

        [HttpGet]
        public ActionResult DLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DLogin(Registration_Form al)
        {
            var a = db.Registration_Forms.SingleOrDefault(b => b.R_Email == al.R_Email && b.R_Password == al.R_Password);
            if (a != null)
            {

                Session["username"] = a.R_Email.ToString();
                Session["userid"] = a.rid.ToString();

                return RedirectToAction("DLoggedIn");

            }
            ViewBag.msg = "Invalid username or password";
            return View();
        }

        public ActionResult DLoggedIn()
        {
            if (Session["userid"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("DoctorRegistrationForm");
            }
        }
    }
}