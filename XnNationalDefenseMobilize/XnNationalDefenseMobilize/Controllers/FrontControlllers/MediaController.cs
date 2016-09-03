using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Media;

namespace XnNationalDefenseMobilize.Controllers
{
    public class MediaController : Controller
    {


        VideoContext vedeoContext = new VideoContext();

        public ActionResult Index()
        {
            return View(vedeoContext.videoLists.ToList());
        }

    }
}
