using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Download;

namespace XnNationalDefenseMobilize.Controllers
{
    public class DownloadController : Controller
    {
        private DownloadContext downloadContext = new DownloadContext();

        public ActionResult Index()
        {
            return View(downloadContext.downloadLists.ToList());
        }

        public ActionResult DownloadList(int type_id, int page_id = 1)
        {
            IEnumerable<Download> downloadList = from items in downloadContext.downloadLists
                                                 where items.downloadCategory_id == type_id
                                                 orderby items.download_release_time
                                                 select items;
            return View(downloadList.ToList());
        }

    }
}