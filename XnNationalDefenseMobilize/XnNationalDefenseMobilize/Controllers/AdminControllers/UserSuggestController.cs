using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Master;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class UserSuggestController : Controller
    {
        private SuggestContext suggestContext =new SuggestContext();
        //
        // GET: /UserSuggest/

        [Authorize]
        public ActionResult Index(int page_id = 1)
        {
            IEnumerable<Suggest> suggestList = from item in suggestContext.suggestLists
                                               orderby item.suggest_id
                                               select item;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(suggestList, 10, 5, page_id);
            return View(multiPagesContrler);
        }

        //刷新和载入数据
        //  /UserSuggest/Refresh
        [Authorize]
        [HttpGet]
        public ActionResult Refresh()
        {
            return Content("刷新成功");
        }

        //删除
        // id为要删除的建议的id
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Suggest s = suggestContext.suggestLists.Find(id);
            suggestContext.suggestLists.Remove(s);
            suggestContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            Suggest s = null;
            String data = Request.Form["ids"];//获取到一个数组
            String[] ids = data.Split(',');
            for (int i = 0; i < ids.Length;i++ )
            {
                s = suggestContext.suggestLists.Find(int.Parse(ids[i]));
                suggestContext.suggestLists.Remove(s);
                suggestContext.SaveChanges();
            }
            return Content("删除成功");
        }

        //搜索
        [Authorize]
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
