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
        public ActionResult Index()
        {
            String title = Request.Form["title"];
            String author = Request.Form["title"];
            String from = Request.Form["from"];
            String classify = Request.Form["classify"];
            String text_abstract = Request.Form["abstract"];
            String text = Request.Form["text"];
            ViewBag.text = text;
            
            return View(homeViewModel);
        }

    }
}
