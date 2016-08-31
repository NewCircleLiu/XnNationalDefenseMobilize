using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers
{
    public class PolicyAdviceController : Controller
    {
        //
        // GET: /PolicyAdvice/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Quiz()
        {
            return View();
        }

        public ActionResult Reply()
        {
            return View();
        }

        public ActionResult ReplyDetail()
        {
            return View();
        }

        //发送问题
        [HttpPost]
        public ActionResult SendQuestion() {
            String user_name = Request.Form["user_name"];
            String user_email = Request.Form["user_email"];
            String title = Request.Form["title"];
            String text = Request.Form["text"];
            return Content("发送成功");
        }
    }
}
