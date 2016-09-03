using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.MediaImpress;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers
{
    public class MediaImpressController : Controller
    {

        MediaImpressContext mediaImpressContext = new MediaImpressContext();

        public ActionResult Index()
        {
            return View(mediaImpressContext.mediaImpressLists.ToList());
        }

        public ActionResult MediaimpressList(int type_id, int page_id = 1)
        {
            IEnumerable<MediaImpress> mediaImpressList = from items in mediaImpressContext.mediaImpressLists
                                                         where items.mediaImpressCategory_id == type_id
                                                         orderby items.mediaImpress_release_time
                                                         select items;

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(mediaImpressList, 8, 5, page_id);
            return View(multiPagesContrler);
        }

        public ActionResult MediaimpressDetail(int id)
        {
            MediaImpress mediaImpress = mediaImpressContext.mediaImpressLists.Find(id);
            return View(mediaImpress);
        }
    }
}
