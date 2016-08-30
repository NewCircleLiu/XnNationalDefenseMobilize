using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class DefenseManageController : Controller
    {
        //
        // GET: /DefenseManage/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PublishNewsPage()
        {
            return View();
        }
    }
}
