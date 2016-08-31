using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class WebInfoController : Controller
    {
        //
        // GET: /WebInfo/

        public ActionResult Index()
        {
            return View();
        }

        //更换图片
        [HttpPost]
        public ActionResult ImageChange()
        {
            String imgLocal = Request.Form["imgLocal"];
            String imgUrl = Request.Form["imgUrl"];
            return Content("更换成功:" + imgLocal);
        }

        //修改信息
        [HttpPost]
        public ActionResult ModifyInfo()
        {
            String address = Request.Form["address"];
            String phone = Request.Form["phone"];
            String fax = Request.Form["fax"];
            String email = Request.Form["email"];
            String webSite = Request.Form["webSite"];
            return Content("修改成功:" + address);
        }
    }
}
