using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class BackLoginController : Controller
    {
        //
        // GET: /BackLogin/

        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login() {
            String account = Request.Form["account"];
            String password = Request.Form["password"];

            return View("../../Views/Admin/BackIndex/Index");
        }

    }
}
