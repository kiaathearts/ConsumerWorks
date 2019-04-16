using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumerWorks.Controllers
{
    public class ConsumerWorksController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult Contracts() {
            return View();
        }

        public ActionResult About() {
            return View();
        }

        public ActionResult PersonalProfile() {
            return View();
        }

    }

}