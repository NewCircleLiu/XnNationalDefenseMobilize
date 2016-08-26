using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class PolicyAdviceController : Controller
    {
        //
        // GET: /PolicyAdvice/
        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();

        public ActionResult Index()
        {
            return View(homeViewModel);
        }

        public ActionResult Quiz()
        {
            return View(homeViewModel);
        }

        public ActionResult Reply()
        {
            return View(homeViewModel);
        }

        public ActionResult ReplyDetail()
        {
            return View(homeViewModel);
        }
    }
}
