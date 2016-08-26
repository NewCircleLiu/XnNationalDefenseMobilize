using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Home;

namespace XnNationalDefenseMobilize.Controllers
{
    public class HomeController : Controller
    {
        private HomeViewModel homeViewModel = new HomeViewModel();

        public ActionResult Index()
        {

            return View(homeViewModel);
        }
    }
}