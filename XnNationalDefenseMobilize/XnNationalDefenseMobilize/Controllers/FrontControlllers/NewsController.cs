using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();


        public ActionResult Index()
        {
            return View(homeViewModel);
        }

        public ActionResult NewsList(int id)
        {
            return View(homeViewModel);
        }

        public ActionResult NewsDetail(int id)
        {
            return View(homeViewModel);
        }

    }
}
