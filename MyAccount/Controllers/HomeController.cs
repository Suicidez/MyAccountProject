using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAccount.Models;
namespace MyAccount.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckLogin(LoginModels Login)
        {
            if (Login.UserName != "" && Login.Password != "")
            {
                
                    ViewBag.Javascript = "";
                return RedirectToAction("MasterSite","Home");
            }
            ViewBag.Javascript = "Wrong";
            return View("Index",Login);
        }
        public ActionResult MasterSite()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page 5555.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}