using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class LinkManageController : Controller
    {
        //
        // GET: /LinkManage/

        public ActionResult Index()
        {
            return View();
        }


        //刷新和载入数据
        //  /UserSuggest/Refresh
        [HttpGet]
        public ActionResult Refresh()
        {
            return Content("刷新成功");
        }

        //删除
        // id为要删除的建议的id
        [HttpPost]
        public ActionResult Delete(String id)
        {
            return Content("删除成功");
        }

        //批量删除
        [HttpPost]
        public ActionResult DeleteMore()
        {
            String links = Request.Form["checkbox"];//获取到一个数组
            return Content("删除成功:" + links);
        }

        //添加链接
        [HttpPost]
        public ActionResult AddLink(String LinkName, String LinkAddress)
        {
            //LinkName：链接名称，LinkAddress：链接地址
            return Content("添加成功");
        }

        //修改链接
        [HttpPost]
        public ActionResult ModifyLink(String linkID,String LinkName, String LinkAddress)
        {
            //LinkName：链接名称，LinkAddress：链接地址,linkID:链接ID
            return Content("修改成功");
        }

        //搜索
        [HttpPost]
        public ActionResult Search()
        {
            //搜索方式
            //by_id:按id
            //by_name:按时间
            String s_type = Request.Form["s_type"];
            String s_text = Request.Form["s_text"];
            return Content("搜索成功:" + s_text);
        }
    }
}
