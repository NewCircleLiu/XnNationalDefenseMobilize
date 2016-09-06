using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Media;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class VideoManageController : Controller
    {

        private VideoContext videoContext = new VideoContext();
        //
        // GET: /VideoManage/
        [Authorize]
        public ActionResult Index(int page_id = 1)
        {

            return View(videoContext);
        }

        //删除
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Video v = videoContext.videoLists.Find(id);
            videoContext.videoLists.Remove(v);
            videoContext.SaveChanges();
            return Content("删除成功:");
        }

        //批量删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            Video v = null;
            String video_ids = Request.Form["video"];
            string[] ids = video_ids.Split(',');
            for (int i = 0; i < ids.Length;i++ )
            {
                v = videoContext.videoLists.Find(int.Parse(ids[i]));
                videoContext.videoLists.Remove(v);
                videoContext.SaveChanges();
            }
            return Content("删除成功");
        }

        //上传视频
        [Authorize]
        [HttpPost]
        public ActionResult UploadVideo()
        {
            Video v = new Video();
            v.video_title = Request.Form["VideoName"];
            v.video_covers = Request.Form["img_url"];
            v.video_source = Request.Form["videoUrl"];
            v.video_release_time = DateTime.Now;

            int classify = int.Parse(Request.Form["classify"]);
            v.videoCategory_id = classify;
            v.videoCategory = videoContext.videoCategoryLists.Find(classify);

            if (ModelState.IsValid)
            {
                videoContext.videoLists.Add(v);
                videoContext.SaveChanges();
            }

            return Content("上传视频成功");
        }

        //搜索
        [Authorize]
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
