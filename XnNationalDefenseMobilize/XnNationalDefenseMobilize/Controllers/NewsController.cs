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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewsList(int id)
        {
            return View();
        }

        public ActionResult NewsDetail(int id)
        {
            return View();
        }

    }
}
