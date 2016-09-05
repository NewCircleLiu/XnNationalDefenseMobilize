using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Home;
using XnNationalDefenseMobilize.Models.News;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class NewsManageController : Controller
    {
        //
        // GET: /NewsManage/

        private NewsInfoContext newsContext = new NewsInfoContext();

        public ActionResult Index(int page_id = 1)
        {
            IEnumerable<NewsInfo> newsList = from items in newsContext.newsInfoLists
                                             orderby items.news_title
                                             select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(newsList, 10, 5, page_id);

            return View(multiPagesContrler);
        }

        //删除
        [HttpPost]
        public ActionResult Delete(int newsId)
        {
            NewsInfo news = newsContext.newsInfoLists.Find(newsId);
            newsContext.newsInfoLists.Remove(news);
            newsContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除
        [HttpPost]
        public ActionResult DeleteMore()
        {
            NewsInfo news = null;
            String newsIds = Request.Form["news"];
            String[] ids = newsIds.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                news = newsContext.newsInfoLists.Find(int.Parse(ids[i]));
                newsContext.newsInfoLists.Remove(news);
                newsContext.SaveChanges();
            }
            return Content("删除成功:");
        }

        //修改新闻页面
        [HttpGet]
        public ActionResult ModifyNews(int id) {
            NewsInfo news = newsContext.newsInfoLists.Find(id);
            return View(news);
        }

        //确定修改新闻
        [HttpPost]
        public ActionResult ModifyNewsConfirm() {

            NewsInfo news = new NewsInfo();

            news.news_id = int.Parse(Request.Form["id"]);
            news.news_title = Request.Form["title"];
            news.news_author = Request.Form["author"];
            news.news_source = Request.Form["from"];
            news.news_abstract = Request.Form["abstract"];
            news.new_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            news.news_content = text;

            int categoryId = int.Parse(Request.Form["classify"]);
            news.newsCategory_id = categoryId;
            

            if(ModelState.IsValid){
                newsContext.Entry(news).State = EntityState.Modified;
                newsContext.SaveChanges();
            }
            return Content("修改成功");
        }

        //
        public ActionResult PublishNewsPage()
        {
            return View();
        }

        //发布新闻
        [HttpPost]
        public ActionResult PublishNews()
        {
            NewsInfo news = new NewsInfo();

            
            news.news_title = Request.Form["title"];
            news.news_author = Request.Form["author"];
            news.news_source = Request.Form["from"];
            news.news_abstract = Request.Form["abstract"];
            news.new_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            news.news_content = text;
             
            int categoryId = int.Parse(Request.Form["classify"]);
            news.newsCategory_id = categoryId;
            news.newsCategory = newsContext.newsCategoryLists.Find(categoryId);

            if (ModelState.IsValid)
            {
                newsContext.newsInfoLists.Add(news);
                newsContext.SaveChanges();
            }
            return Content("发布成功:");
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
