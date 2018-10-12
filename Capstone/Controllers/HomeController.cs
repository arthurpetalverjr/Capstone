using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
      
        public ActionResult ViewMoodDiary()
        {
            return View();
        }
        public ActionResult ViewBills()
        {
            return View();
        }
        public ActionResult ViewActivityLog()
        {
            return View();
        }
        public ActionResult EditMoodDiary()
        {
            return View();
        }
        public ActionResult EditProfile()
        {
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();
        }
    }
}