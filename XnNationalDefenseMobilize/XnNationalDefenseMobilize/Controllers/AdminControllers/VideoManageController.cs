using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class VideoManageController : Controller
    {
        //
        // GET: /VideoManage/

        public ActionResult Index()
        {
            return View();
        }

        //刷新
        [HttpGet]
        public ActionResult Refresh()
        {

            return Content("刷新成功");
        }

        //删除
        [HttpPost]
        public ActionResult Delete(String video_id)
        {

            return Content("删除成功:" + video_id);
        }

        [HttpPost]
        public ActionResult DeleteMore()
        {
            String video_id = Request.Form["video"];
            return Content("删除成功:" + video_id);
        }
    }
}
