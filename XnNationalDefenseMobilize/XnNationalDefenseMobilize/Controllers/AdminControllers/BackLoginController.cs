using System;
using System.Collections.Generic;
using System.Data;
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
                Session["username"] = username;
                return RedirectToAction("Index", "ImgManage");
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

        [HttpPost]
        public ActionResult ModifyUserInfo()
        {
            string origin_username = Request.Form["origin_username"];
            string origin_password = Request.Form["origin_pass"];
            string new_username = Request.Form["new_username"];
            string new_password = Request.Form["new_pass"];

            User[] users = account_db.userLists.Where(u => u.user_name == origin_username && u.user_password == origin_password).ToArray();
            if (users.Count() > 0)
            {
                account_db.userLists.Find(users[0].user_id).user_name = new_username;
                account_db.userLists.Find(users[0].user_id).user_password = new_password;
                account_db.SaveChanges();
                return Content("修改账户成功");
            }

            else
                return Content("原始账户输入错误");
        }

    }
}