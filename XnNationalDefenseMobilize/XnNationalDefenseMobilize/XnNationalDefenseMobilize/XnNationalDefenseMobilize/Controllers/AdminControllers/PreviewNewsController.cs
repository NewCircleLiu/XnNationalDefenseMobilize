using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class PreviewNewsController : Controller
    {
        //
        // GET: /PreviewNews/

        public ActionResult Index(String text)
        {
            return View();
        }

    }
}
