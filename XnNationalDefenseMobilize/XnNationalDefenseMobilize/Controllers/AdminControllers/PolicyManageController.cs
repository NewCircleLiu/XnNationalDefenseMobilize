using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class PolicyManageController : Controller
    {
        //
        // GET: /PolicyManage/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PublishNewsPage()
        {
            return View();
        }

        //发布
        [HttpPost]
        public ActionResult PublishNews()
        {
            //标题
            String title = Request.Form["text"];
            //作者
            String author = Request.Form["author"];
            //来源
            String from = Request.Form["from"];
            //内容
            //内容中的换行用“<br/>”代替
            String text = Request.Form["text"];
            return Content("发布成功:" + text);
        }

        //回复留言
        [HttpPost]
        public ActionResult ReplayMessage()
        {
            String messageid = Request.Form["messageid"];
            String messageTitle = Request.Form["messageTitle"];
            String text = Request.Form["text"];

            return Content("回复成功");
        }


        //刷新
        [HttpPost]
        public ActionResult Refresh()
        {
            String id = Request.Form["id"];
            return Content("刷新成功:"+id);
        }

        //删除
        [HttpPost]
        public ActionResult Delete(String newsId)
        {
            return Content("删除成功:" + newsId);
        }

        //批量删除
        [HttpPost]
        public ActionResult DeleteMore()
        {
            String newsIds = Request.Form["news"];
            return Content("删除成功:" + newsIds);
        }

        //搜索
        [HttpPost]
        public ActionResult Search()
        {
            //搜索方式
            //by_name:按名称
            //by_type:按类型
            String s_type = Request.Form["s_type"];
            String s_text = Request.Form["s_text"];
            //模块名称
            String model = Request.Form["model"];
            return Content("搜索成功:" + model);
        }
    }
}
