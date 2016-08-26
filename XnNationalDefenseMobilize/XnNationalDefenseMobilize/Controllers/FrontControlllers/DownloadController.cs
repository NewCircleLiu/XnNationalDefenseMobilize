using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class DownloadController : Controller
    {
        //
        // GET: /Download/

        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();

        public ActionResult Index()
        {
            return View(homeViewModel);
        }

        public ActionResult DownloadList()
        {

            return View(homeViewModel);
        }

    }
}
