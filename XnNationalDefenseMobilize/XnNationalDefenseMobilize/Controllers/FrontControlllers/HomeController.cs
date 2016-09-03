using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Home;

namespace XnNationalDefenseMobilize.Controllers
{
    public class HomeController : Controller
    {
        private HomeViewModel homeViewModel = new HomeViewModel();

        public ActionResult Index()
        {

            return View(homeViewModel);
        }

        //发送用户建议
        [HttpPost]
        public ActionResult SendUserSuggest()
        {
            String user_name = Request.Form["user_name"];
            String user_email = Request.Form["user_email"];
            String user_phone = Request.Form["user_phone"];
            String user_suggest = Request.Form["user_suggest"];
            return Content("发送成功");
        }
    }
}