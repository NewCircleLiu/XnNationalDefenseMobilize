using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class RootManageController : Controller
    {
        //
        // GET: /RootManage/

        public ActionResult Index()
        {
            return View();
        }

        //删除
        [HttpPost]
        public ActionResult DeleteRole()
        {
            String roleId = Request.Form["roleId"];
            return Content("删除成功");
        }

        //修改密码
        [HttpPost]
        public ActionResult ModifyRolePass()
        {
            String roleId = Request.Form["roleId"];
            String oldPass = Request.Form["oldPass"];
            String newPass = Request.Form["newPass"];
            return Content("修改成功");
        }

        //添加角色
        [HttpPost]
        public ActionResult AddRole()
        {
            String role = Request.Form["role"];
            String roleAccount = Request.Form["roleAccount"];
            String rolePass = Request.Form["rolePass"];
            String roleDesc = Request.Form["roleDesc"];
            return Content("添加成功");
        }

    }
}
