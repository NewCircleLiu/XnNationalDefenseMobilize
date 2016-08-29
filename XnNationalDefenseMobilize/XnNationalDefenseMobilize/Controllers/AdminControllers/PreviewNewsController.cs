using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class PreviewNewsController : Controller
    {
        //
        // GET: /PreviewNews/

        private XnNationalDefenseMobilize.Models.Home.HomeViewModel homeViewModel = new XnNationalDefenseMobilize.Models.Home.HomeViewModel();

        [HttpPost]
        public ActionResult Index(String title,String author,String frome,String classify,String text)
        {

            ViewBag.text = text;
            
            return View(homeViewModel);
        }

    }
}
