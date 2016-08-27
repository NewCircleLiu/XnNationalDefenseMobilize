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

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /GrassrootList/

        public ActionResult GrassrootList() 
        {
            return View();
        }

        public ActionResult GrassrootDetail()
        {
            return View();
        }

    }
}
