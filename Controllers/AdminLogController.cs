using DoctorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorWeb.Controllers
{
    public class AdminLogController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();
        // GET: AdminLog
        public ActionResult Index()
        {
            ViewBag.Msg = "";
            return View();
        }
        [HttpGet]
        public ActionResult adminloginpanel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adminloginpanel(Adminlogin al)
        {
            var a = db.Adminlogins.Single(b => b.AdminEmail == al.AdminEmail && b.AdminPassword == al.AdminPassword);
            if(a!=null)
            {
               
                    Session["username"] = a.AdminEmail.ToString();
                    Session["userid"] = a.AdminId.ToString();
                
                return RedirectToAction("LoggedIn");
                
            }
            ViewBag.msg = "Invalid username or password";
            return View();
            
        }

        public ActionResult LoggedIn()
        {
            if (Session["userid"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("AdminloginPanel");
            }
        }


    }
}