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
        private MainModels MainModel = new MainModels();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckLogin(MyAccount.Models.MasterModels.mstUser User)
        {
            if (User.UserId != "" && User.Password != "")
            {

               // MasterControllers.mstUsersController ss = new MasterControllers.mstUsersController();
              //  var d = ss.Details(1);
                    var UserModels =  MainModel.mstUser().Where(x => x.UserId == User.UserId && x.Password == User.Password).ToList();
                    if (UserModels.Count > 0)
                    {
                   ViewBag.Javascript = "";
                    return RedirectToAction("MasterSite", "Home");
                    }
                   
                   
                
                 
            }
            @ViewBag.AlertHeader = "";
            @ViewBag.AlertMsg = "Wrong Username or password. Please Try again";
            ViewBag.Javascript = "Wrong";
            return View("Index",User);
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