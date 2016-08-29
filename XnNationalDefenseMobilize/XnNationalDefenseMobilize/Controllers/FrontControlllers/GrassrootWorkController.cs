using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.GrassrootWork;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers
{
    public class GrassrootWorkController : Controller
    {
        GrassrootNewsContext grassNewsContext = new GrassrootNewsContext();

        public ActionResult Index()
        {
            return View(grassNewsContext.grassrootNewsLists.ToList());
        }


        public ActionResult GrassrootList(int type_id, int page_id = 1)
        {
            IEnumerable<GrassrootNews> newsList = from items in grassNewsContext.grassrootNewsLists
                                                  where items.disTrict.district_id == type_id
                                                  orderby items.grassrootNews_title
                                                  select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(newsList, 5, 5, page_id);
            return View(multiPagesContrler);
        }

        public ActionResult GrassrootDetail(int id)
        {
            IEnumerable<GrassrootNews> news = from newsDetail in grassNewsContext.grassrootNewsLists
                                              where newsDetail.grassrootNews_id == id
                                              select newsDetail;
            GrassrootNews singleNews = news.First();
            return View(singleNews);
        }

    }
}
