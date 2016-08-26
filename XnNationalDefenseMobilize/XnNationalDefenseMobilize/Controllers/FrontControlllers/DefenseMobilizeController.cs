using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class DefenseMobilizeController : Controller
    {
        //
        // GET: /DefenseMobilize/
        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();

        public ActionResult Index()
        {
            return View(homeViewModel);
        }

        public ActionResult DefenseList()
        {
            return View(homeViewModel);
        }

        public ActionResult DefenseDetail(int id)
        {
            return View(homeViewModel);
        }

    }
}
