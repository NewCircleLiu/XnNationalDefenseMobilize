using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class ImgManageController : Controller
    {
        //
        // GET: /ImgManage/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //更换图片
        [Authorize]
        [HttpPost]
        public ActionResult ImageChange(){
            String imgLocal = Request.Form["imgLocal"];
            String imgUrl = Request.Form["imgUrl"];
            return Content("更换成功:" + imgLocal);
        }
    }
}
