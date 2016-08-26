using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class GrassrootWorkController : Controller
    {
        //
        // GET: /GrassrootWork/

        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();

        public ActionResult Index()
        {
            return View(homeViewModel);
        }

        //
        // GET: /GrassrootList/

        public ActionResult GrassrootList() 
        {
            return View(homeViewModel);
        }

        public ActionResult GrassrootDetail()
        {
            return View(homeViewModel);
        }

    }
}
