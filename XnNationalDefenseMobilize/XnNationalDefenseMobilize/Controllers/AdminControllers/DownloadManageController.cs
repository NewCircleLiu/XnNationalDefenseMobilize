using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Download;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class DownloadManageController : Controller
    {
        DownloadContext downloadContext = new DownloadContext();
        //
        // GET: /DownloadManage/

        [Authorize]
        public ActionResult Index()
        {
            return View(downloadContext);
        }

        //删除
        [HttpPost]
        public ActionResult Delete()
        {
            int id = int.Parse(Request.Form["id"]);
            Download download = downloadContext.downloadLists.Find(id);
            downloadContext.downloadLists.Remove(download);
            downloadContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            Download download = null;
            String newsid = Request.Form["news"];
            String[] ids = newsid.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                download = downloadContext.downloadLists.Find(int.Parse(ids[i]));
                downloadContext.downloadLists.Remove(download);
                downloadContext.SaveChanges();
            }
            return Content("删除成功");
        }

        //搜索
        [Authorize]
        [HttpPost]
        public ActionResult Search()
        {
            //搜索模块
            //file_search:
            //pc_search:
            //phone_search:
            //book_search:
            String model = Request.Form["model"];
            //搜索方式
            //by_id:
            //by_name:
            String s_type = Request.Form["s_type"];
            //搜索内容
            String s_text = Request.Form["s_text"];

            return Content("删除成功:" + s_text);
        }

        //上传
        [Authorize]
        [HttpPost]
        public ActionResult Upload() {
            Download d = new Download();

            d.download_title = Request.Form["fileName"];
            d.download_source = Request.Form["fileUrl"];
            d.download_release_time = DateTime.Now;
            int classify = int.Parse(Request.Form["classify"]);
            d.downloadCategory_id = classify;
            d.downloadCategory = downloadContext.downloadCategoryLists.Find(classify);

            if (ModelState.IsValid)
            {
                downloadContext.downloadLists.Add(d);
                downloadContext.SaveChanges();
            }

            return Content("上传成功");
        }
    }
}
