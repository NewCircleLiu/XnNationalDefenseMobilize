using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.DefenseMobilize;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class DefenseManageController : Controller
    {
        private DefenseNewsContext defenseNewsContext = new DefenseNewsContext();

        //
        // GET: /DefenseManage/

        public ActionResult Index(int page_id = 1)
        {
            IEnumerable<DefenseNews> newsList = from items in defenseNewsContext.defenseNewsLists
                                             orderby items.defenseNews_title
                                             select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(newsList, 10, 5, page_id);

            return View(multiPagesContrler);
        }

        public ActionResult PublishNewsPage()
        {
            return View();
        }

        //发布新闻
        [HttpPost]
        public ActionResult PublishNews()
        {
            DefenseNews defenseNews = new DefenseNews();

            defenseNews.defenseNews_title = Request.Form["title"];
            defenseNews.defenseNews_author = Request.Form["author"];
            defenseNews.defenseNews_source = Request.Form["from"];
            defenseNews.defenseNews_abstract = Request.Form["abstract"];
            defenseNews.defenseNews_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            defenseNews.defenseNews_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            defenseNews.defenseCategory_id = categoryId;
            defenseNews.defenseNewsCategory = defenseNewsContext.defenseCategoryLists.Find(categoryId);

            if (ModelState.IsValid)
            {
                defenseNewsContext.defenseNewsLists.Add(defenseNews);
                defenseNewsContext.SaveChanges();
            }
            return Content("发布成功:");
        }
        
        //修改新闻页面
        [HttpGet]
        public ActionResult ModifyNews(int id) {
            DefenseNews defenseNews = defenseNewsContext.defenseNewsLists.Find(id);
            return View(defenseNews);
        }

        //确定修改新闻
        [HttpPost]
        public ActionResult ModifyNewsConfirm()
        {

            DefenseNews defenseNews = new DefenseNews();

            defenseNews.defenseNews_id = int.Parse(Request.Form["id"]);
            defenseNews.defenseNews_title = Request.Form["title"];
            defenseNews.defenseNews_author = Request.Form["author"];
            defenseNews.defenseNews_source = Request.Form["from"];
            defenseNews.defenseNews_abstract = Request.Form["abstract"];
            defenseNews.defenseNews_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            defenseNews.defenseNews_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            defenseNews.defenseCategory_id = categoryId;


            if (ModelState.IsValid)
            {
                defenseNewsContext.Entry(defenseNews).State = EntityState.Modified;
                defenseNewsContext.SaveChanges();
            }
            return Content("修改成功");
        }

        //删除
        [HttpPost]
        public ActionResult Delete(String newsId)
        {
            DefenseNews defenseNews = defenseNewsContext.defenseNewsLists.Find(int.Parse(newsId));
            defenseNewsContext.defenseNewsLists.Remove(defenseNews);
            defenseNewsContext.SaveChanges();
            return Content("删除成功:" + newsId);
        }

        //批量删除
        [HttpPost]
        public ActionResult DeleteMore()
        {
            DefenseNews defenseNews = null;
            String newsIds = Request.Form["news"];
            String[] ids = newsIds.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                defenseNews = defenseNewsContext.defenseNewsLists.Find(int.Parse(ids[i]));
                defenseNewsContext.defenseNewsLists.Remove(defenseNews);
                defenseNewsContext.SaveChanges();
            }
            return Content("删除成功:");
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
