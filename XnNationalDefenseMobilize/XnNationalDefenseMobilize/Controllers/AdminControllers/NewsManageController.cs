using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Home;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class NewsManageController : Controller
    {
        //
        // GET: /NewsManage/

        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PublishNewsPage()
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

        //发布新闻
        [HttpPost]
        public ActionResult PublishNews()
        {
            //新闻标题
            String title = Request.Form["text"];
            //新闻作者
            String author = Request.Form["author"];
            //新闻来源
            String from = Request.Form["from"];
            //新闻分类
            //gjxw:国际新闻,gnxw:国内新闻,jsxw：军事新闻，shxw：社会新闻，xnxw：西宁新闻
            String classify = Request.Form["classify"];
            //新闻摘要
            //标签中的“<”符号用“#lt;”替换，“>”符号用“#gt;”替换
            String Newabstract = Request.Form["abstract"];
            //新闻内容
            //内容中的换行用“<br/>”代替
            String text = Request.Form["text"];
            return Content("发布成功:" + text);
        }
    }
}
