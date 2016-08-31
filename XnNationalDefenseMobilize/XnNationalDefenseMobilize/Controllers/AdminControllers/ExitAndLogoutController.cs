using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class ExitAndLogoutController : Controller
    {
        //
        // GET: /ExitAndLogout/

        //注销
        public ActionResult Index()
        {
            return View("../../Views/Admin/BackLogin/Index");
        }
    }
}
