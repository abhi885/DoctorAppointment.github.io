using DoctorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorWeb.Controllers
{
    public class HomeController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(string Id)
        {
            ViewBag.Name = "foo";
            //logic to fetch details on ID
            return View("Details");
        }
        public ActionResult Myindex()
        {
            ViewBag.dr = db.Registration_Forms.ToList();
            ViewBag.specialist = db.Registration_Forms.Select(c => c.R_Specialization).Distinct().ToList();
            ViewBag.city = db.Registration_Forms.Select(c => c.R_City).Distinct().ToList();
            ViewBag.state = db.Registration_Forms.Select(c => c.R_State).Distinct().ToList();
            ViewBag.country = db.Registration_Forms.Select(c => c.R_Country).Distinct().ToList();
            return View();
        }

        public ActionResult login()
        {
            ViewBag.msg = "";
            return View();
        }
        public ActionResult login(Registration_Form rf)
        {
            var a = db.Registration_Forms.Single(b => b.R_Email == rf.R_Email && b.R_Password == rf.R_Password);
            if (a != null)
            {

                Session["username"] = a.R_Email.ToString();
                Session["userid"] = a.rid.ToString();
                return RedirectToAction("Myindex");
            }
            ViewBag.msg = "Invalid username or password";
            return View();
        }
        public ActionResult logout()
        {
            Session.Abandon();
            return RedirectToAction("Myindex");
        }

        public ActionResult search()
        {
            //ViewBag.field = db.Registration_Forms.Select(c => c.R_Fields).Distinct().ToList();

            ViewBag.specialist = db.Registration_Forms.Select(c => c.R_Specialization).Distinct().ToList();
            ViewBag.city = db.Registration_Forms.Select(c => c.R_City).Distinct().ToList();
            ViewBag.state = db.Registration_Forms.Select(c => c.R_State).Distinct().ToList();
            ViewBag.country = db.Registration_Forms.Select(c => c.R_Country).Distinct().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult search(string txtfeild,string txtcity,string txtstate,string txtcountry)
        {
            //ViewBag.field = db.Registration_Forms.Select(c => c.R_Fields).Distinct().ToList();

            ViewBag.specialist = db.Registration_Forms.Select(c => c.R_Specialization).Distinct().ToList();
            ViewBag.city = db.Registration_Forms.Select(c => c.R_City).Distinct().ToList();
            ViewBag.state = db.Registration_Forms.Select(c => c.R_State).Distinct().ToList();
            ViewBag.country = db.Registration_Forms.Select(c => c.R_Country).Distinct().ToList();

            List<Registration_Form> r = db.Registration_Forms.Where(l => l.R_Specialization.Equals(txtfeild) && l.R_City.Contains(txtcity) && l.R_State.Contains(txtstate) && l.R_Country.Contains(txtcountry)).ToList();
            ViewBag.a = r;
            return View();
        }

        public ActionResult count(string c)
        {
            return View();
        }



    }
}