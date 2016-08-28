using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.DefenseMobilize;

namespace XnNationalDefenseMobilize.Controllers
{
    public class DefenseMobilizeController : Controller
    {

        public DefenseNewsContext defenseNewsContext = new DefenseNewsContext();

        public ActionResult Index()
        {
            return View(defenseNewsContext.defenseNewsLists.ToList());
        }

        public ActionResult DefenseList()
        {
            return View();
        }

        public ActionResult DefenseDetail(int id)
        {
            return View();
        }

    }
}
