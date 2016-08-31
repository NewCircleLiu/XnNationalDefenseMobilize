using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
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

        //修改标语
        //newSlogan为新的标语
        //sloganId为标语id，表示标语位置,取值范围为[slogan1,slogan2,slogan3,slogan4]
        //  /SloganManage/ChangeSlogan   
        [HttpPost]
        public ActionResult ChangeSlogan(String newSlogan, String sloganId)
        {
            return Content("修改成功");
        }


        //修改标语状态
        //sloganId为标语id，表示标语位置,取值范围为[s1,s2,s3,s4]
        [HttpPost]
        public ActionResult ChangeSloganStatus(String sloganId)
        {
            return Content("禁用成功");
        }
    }
}
