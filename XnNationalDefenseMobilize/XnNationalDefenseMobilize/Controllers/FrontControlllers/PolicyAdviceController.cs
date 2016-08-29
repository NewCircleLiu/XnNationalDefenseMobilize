using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.PolycyAdvice;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers
{
    public class PolicyAdviceController : Controller
    {

        public ActionResult Index(int page_id = 1)
        {
            CommonQuesContext commonQuesContext = new CommonQuesContext();
            IEnumerable<CommonQues> questionList = commonQuesContext.commonQuesLists.ToList();

            string s = questionList.GetType().ToString();

            int m = questionList.Count();

            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(questionList, 12, 5, page_id);

            return View(multiPagesContrler);
        }

        public ActionResult Quiz()
        {
            return View();
        }

        public ActionResult Reply()
        {
            return View();
        }

        public ActionResult ReplyDetail()
        {
            return View();
        }
    }
}
