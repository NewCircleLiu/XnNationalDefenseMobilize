using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using XnNationalDefenseMobilize.Models.User;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class BackLoginController : Controller
    {
        //
        // GET: /BackLogin/

        private UserContext account_db = new UserContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login() {
            String username = Request.Form["username"];
            String password = Request.Form["password"];

            var exsit = account_db.userLists.Where(u => u.user_name == username && u.user_password == password).ToList();
            if (exsit.Count() > 0)
            {
                ViewBag.validate = true;
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Index", "BackIndex");
            }
            else
            {
                TempData["validate"] = false;
                return RedirectToAction("Index", "BackLogin");
            }
        }

        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "BackLogin");
        }
    }
}