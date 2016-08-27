using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.News;

namespace XnNationalDefenseMobilize.Controllers
{
    public class NewsController : Controller
    {
        NewsInfoContext newsInfoTable = new NewsInfoContext();

        public ActionResult Index()
        {
            return View(newsInfoTable.newsInfoLists.ToList());
        }

        public ActionResult NewsList(int type_id)
        {
            IEnumerable<NewsInfo> newsList = from items in newsInfoTable.newsInfoLists
                                             where items.newsCategory.newsCategory_id == type_id
                                             orderby items.news_title
                                             select items;

            return View(newsList);
        }

        public ActionResult NewsDetail(int id)
        {
            return View();
        }

    }
}
