using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class UserSuggestController : Controller
    {
        //
        // GET: /UserSuggest/

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
            String data = Request.Form["checkbox"];//获取到一个数组
            return Content("删除成功");
        }

        //搜索
        [HttpPost]
        public ActionResult Search()
        {
            //搜索方式
            //by_name:按用户姓名搜索
            //by_phone:按电话搜索
            String s_type = Request.Form["s_type"];
            String s_text = Request.Form["s_text"];
            return Content("搜索成功:" + s_text);
        }

    }
}
