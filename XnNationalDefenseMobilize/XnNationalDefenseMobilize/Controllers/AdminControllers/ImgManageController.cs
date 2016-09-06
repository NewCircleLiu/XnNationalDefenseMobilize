using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Home;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class ImgManageController : Controller
    {
        public HomeImageContext homeImageContext = new HomeImageContext();

        [Authorize]
        public ActionResult Index()
        {
            return View(homeImageContext.homeImageLists.ToArray());
        }

        //更换图片
        [Authorize]
        [HttpPost]
        public ActionResult ImageChange(){
            
            int imageId = int.Parse(Request.Form["imgLocal"]);
            String imgUrl = Request.Form["imgUrl"];

             HomeImage[] imgs = homeImageContext.homeImageLists.Where(u => u.image_id == imageId).ToArray();
             HomeImage thisImg = imgs[0];

             if (imgs.Count() > 0)
                 thisImg.image_path = imgUrl;
             else
             {
                 HomeImage hi = new HomeImage();
                 hi.image_path = imgUrl;
                 homeImageContext.homeImageLists.Add(hi);
             }
             homeImageContext.SaveChanges();

            return Content("图片修改成功");
        }
    }
}
