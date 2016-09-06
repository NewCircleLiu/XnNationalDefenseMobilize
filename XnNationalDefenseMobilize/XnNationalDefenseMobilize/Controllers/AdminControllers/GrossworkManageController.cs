using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.GrassrootWork;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class GrossworkManageController : Controller
    {
        GrassrootNewsContext gn = new GrassrootNewsContext();
        //
        // GET: /GrossworkManage/

        [Authorize]
        public ActionResult Index(int page_id = 1)
        {
            IEnumerable<GrassrootNews> newsList = from items in gn.grassrootNewsLists
                                             orderby items.grassrootNews_release_time
                                             select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(newsList, 10, 5, page_id);

            return View(multiPagesContrler);
        }

        [Authorize]
        public ActionResult PublishNewsPage()
        {
            return View();
        }

        //发布新闻
        [Authorize]
        [HttpPost]
        public ActionResult PublishNews()
        {
            GrassrootNews g = new GrassrootNews();
            g.grassrootNews_title = Request.Form["title"];
            g.grassrootNews_author = Request.Form["author"];
            g.grassrootNews_source = Request.Form["from"];
            g.grassrootNews_abstract = Request.Form["abstract"];
            g.grassrootNews_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            g.grassrootNews_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            g.district_id = categoryId;
            g.disTrict = gn.DistrictLists.Find(categoryId);

            if (ModelState.IsValid)
            {
                gn.grassrootNewsLists.Add(g);
                gn.SaveChanges();
            }
            return Content("发布成功" );
        }

        //修改页面
        [Authorize]
        [HttpGet]
        public ActionResult ModifyPage(int id) {
            GrassrootNews g = gn.grassrootNewsLists.Find(id);
            return View(g);
        }

        //修改
        [Authorize]
        [HttpPost]
        public ActionResult Modify()
        {
            GrassrootNews g = new GrassrootNews();
            g.grassrootNews_id = int.Parse(Request.Form["id"]);
            g.grassrootNews_title = Request.Form["title"];
            g.grassrootNews_author = Request.Form["author"];
            g.grassrootNews_source = Request.Form["from"];
            g.grassrootNews_abstract = Request.Form["abstract"];
            g.grassrootNews_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            g.grassrootNews_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            g.district_id = categoryId;

            if (ModelState.IsValid)
            {
                gn.Entry(g).State = EntityState.Modified;
                gn.SaveChanges();
            }
            return Content("修改成功");
        }

        //删除
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            GrassrootNews g = gn.grassrootNewsLists.Find(id);
            gn.grassrootNewsLists.Remove(g);
            gn.SaveChanges();
            return Content("删除成功");
        }

        //批量删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            GrassrootNews g = null;
            String data = Request.Form["ids"];
            String[] ids = data.Split(',');
            for (int i = 0; i < ids.Length;i++ )
            {
                g = gn.grassrootNewsLists.Find(int.Parse(ids[i]));
                gn.grassrootNewsLists.Remove(g);
                gn.SaveChanges();
            }
            return Content("删除成功" );
        }

        //搜索
        [Authorize]
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
