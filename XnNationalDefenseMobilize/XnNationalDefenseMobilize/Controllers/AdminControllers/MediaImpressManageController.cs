using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.MediaImpress;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class MediaImpressManageController : Controller
    {
        private MediaImpressContext mediaImpressContext = new MediaImpressContext();
        //
        // GET: /MediaImpressManage/
        [Authorize]
        public ActionResult Index(int page_id=1)
        {
            IEnumerable<MediaImpress> mediaImpressList = from item in mediaImpressContext.mediaImpressLists
                                                         orderby item.mediaImpress_release_time
                                                         select item;
            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(mediaImpressList, 10, 5, page_id);
            return View(multiPagesContrler);
        }

        //
        [Authorize]
        [HttpGet]
        public ActionResult PublishPage() {
            return View();
        }

        //
        [Authorize]
        [HttpPost]
        public ActionResult Publish()
        {
            MediaImpress mediaImpress = new MediaImpress();
            mediaImpress.mediaImpress_title = Request.Form["title"];
            mediaImpress.mediaImpress_source = Request.Form["from"];
            mediaImpress.mediaImpress_abstract = Request.Form["abstract"];
            mediaImpress.mediaImpress_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            mediaImpress.mediaImpress_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            mediaImpress.mediaImpressCategory_id = categoryId;
            mediaImpress.mediaImpressCategory = mediaImpressContext.mediaImpressCategoryLists.Find(categoryId);

            if (ModelState.IsValid)
            {
                mediaImpressContext.mediaImpressLists.Add(mediaImpress);
                mediaImpressContext.SaveChanges();
            }
            return Content("发布成功");
        }

        //
        [Authorize]
        [HttpGet]
        public ActionResult ModifyPage(int id)
        {
            MediaImpress mediaImpress = mediaImpressContext.mediaImpressLists.Find(id);
            return View(mediaImpress);
        }

        //修改
        [Authorize]
        [HttpPost]
        public ActionResult Modify()
        {
            MediaImpress mediaImpress = new MediaImpress();
            mediaImpress.mediaImpress_title = Request.Form["title"];
            mediaImpress.mediaImpress_source = Request.Form["from"];
            mediaImpress.mediaImpress_id = int.Parse(Request.Form["id"]);
            mediaImpress.mediaImpress_abstract = Request.Form["abstract"];
            mediaImpress.mediaImpress_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            mediaImpress.mediaImpress_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            mediaImpress.mediaImpressCategory_id = categoryId;

            if (ModelState.IsValid) {
                mediaImpressContext.Entry(mediaImpress).State = EntityState.Modified;
                mediaImpressContext.SaveChanges();
            }
            return Content("修改成功");
        }

        //删除
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id) {
            MediaImpress m = mediaImpressContext.mediaImpressLists.Find(id);
            mediaImpressContext.mediaImpressLists.Remove(m);
            mediaImpressContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            MediaImpress m = null;
            string newsIds = Request.Form["news"];
            string[] ids = newsIds.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                m = mediaImpressContext.mediaImpressLists.Find(int.Parse(ids[i]));
                mediaImpressContext.mediaImpressLists.Remove(m);
                mediaImpressContext.SaveChanges();
            }
            return Content("删除成功");
        }
    }
}
