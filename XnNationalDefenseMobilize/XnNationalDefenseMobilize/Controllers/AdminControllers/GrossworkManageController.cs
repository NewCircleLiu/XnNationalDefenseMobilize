using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class GrossworkManageController : Controller
    {
        //
        // GET: /GrossworkManage/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PublishNewsPage()
        {
            return View();
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
            // <option value="cbq">城北区</option>
            //<option value="czq">城中区</option>
             //<option value="cnq">城南区</option>
             //<option value="cxq">城西区</option>
             //<option value="cdq">城东区</option>
             //<option value="dtx">大通县</option>
             //<option value="hzx">湟中县</option>
             //<option value="hyx">湟源县</option>
            String classify = Request.Form["classify"];
            //新闻摘要
            //标签中的“<”符号用“#lt;”替换，“>”符号用“#gt;”替换
            String Newabstract = Request.Form["abstract"];
            //新闻内容
            //内容中的换行用“<br/>”代替
            String text = Request.Form["text"];
            return Content("发布成功:" + text);
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

        //搜索
        [HttpPost]
        public ActionResult Search()
        {
            //搜索方式
            //by_name:按名称
            //by_type:按类型
            String s_type = Request.Form["s_type"];
            String s_text = Request.Form["s_text"];
            return Content("搜索成功:" + s_text);
        }
    }
}
