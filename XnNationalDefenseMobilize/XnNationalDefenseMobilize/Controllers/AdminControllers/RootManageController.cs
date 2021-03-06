﻿using System;
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
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteRole()
        {
            String roleId = Request.Form["roleId"];
            return Content("删除成功");
        }

        //添加角色
        [Authorize]
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
