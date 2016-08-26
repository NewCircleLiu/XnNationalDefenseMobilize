using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class MediaController : Controller
    {
        //
        // GET: /Media/
        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();

        public ActionResult Index()
        {
            return View(homeViewModel);
        }

    }
}
