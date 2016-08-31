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

        //批量删除
        [HttpPost]
        public ActionResult DeleteMore()
        {
            String video_id = Request.Form["video"];
            return Content("删除成功:" + video_id);
        }

        //上传视频
        [HttpPost]
        public ActionResult UploadVideo()
        {
            //视频名称
            String video_name = Request.Form["VideoName"];
            //视频分类
            //v_zbxc:征兵宣传
            //v_gfjy:国防教育
            //v_yjys:拥军优属
            //v_dyyl:动员演练
            String video_classify = Request.Form["classify"];
            //视频路径
            String video_url = Request.Form["videoUrl"];

            return Content("上传视频成功" + video_name);
        }

        //搜索
        [HttpPost]
        public ActionResult Search()
        {
            String s_text = Request.Form["s_text"];
            //搜索方式
            //by_name:按名称
            //by_classify:按分类
            String s_type = Request.Form["s_type"];
            return Content("搜索成功:" + s_text);
        }
    }
}
