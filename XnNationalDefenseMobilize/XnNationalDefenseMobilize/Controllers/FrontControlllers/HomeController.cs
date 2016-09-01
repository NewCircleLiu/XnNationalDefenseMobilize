using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Home;
using XnNationalDefenseMobilize.Models.Master;

namespace XnNationalDefenseMobilize.Controllers
{
    public class HomeController : Controller
    {
        private HomeViewModel homeViewModel = new HomeViewModel();

        public ActionResult Index()
        {
            return View(homeViewModel);
        }

        //发送用户建议
        [HttpPost]
        public ActionResult SendUserSuggest()
        {
            if (Request.IsAjaxRequest())
            {
                Suggest suggest = new Suggest();
                suggest.suggest_email = Request.Form["user_email"];
                suggest.suggest_phone = Request.Form["user_phone"];
                suggest.suggest_content = Request.Form["user_suggest"];


                SuggestContext suggestContext = new SuggestContext();
                suggestContext.suggestLists.Add(suggest);
                suggestContext.SaveChanges();
                return Content("发送意见建议成功");
            }
            else
                return View("Index");
        }
    }
}