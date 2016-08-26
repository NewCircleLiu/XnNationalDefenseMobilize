using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Master;

namespace XnNationalDefenseMobilize.Controllers
{
    public class HomeController : Controller
    {
        private LinkListContext db = new LinkListContext();

        public ActionResult Index()
        {

            return View(db.linkLists.ToList());
        }
    }
}