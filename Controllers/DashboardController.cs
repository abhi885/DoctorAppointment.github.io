using DoctorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorWeb.Controllers
{
    public class DashboardController : Controller
    {
        private DoctorDBContext db = new DoctorDBContext();
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}