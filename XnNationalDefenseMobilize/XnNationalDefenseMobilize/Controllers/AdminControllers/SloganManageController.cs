using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Slogan;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class SloganManageController : Controller
    {
        //
        // GET: /SloganManage/

        SloganContext sloganContxt = new SloganContext();

        public ActionResult Index()
        {
            return View(sloganContxt.sloganLists.ToList());
        }

        [HttpPost]
        public ActionResult ChangeSlogan()
        {
            Slogan slogan = new Slogan();
            slogan.slogan_id = int.Parse(Request.Form["slogan_id"]);
            slogan.slogan__content = Request.Form["sloganContent"];
            slogan.slogan_location = Request.Form["slogan_localtion"];

            if (ModelState.IsValid)
            {
                sloganContxt.Entry(slogan).State = EntityState.Modified;
                sloganContxt.SaveChanges();
            }
            return Content("修改成功");
        }

    }
}
