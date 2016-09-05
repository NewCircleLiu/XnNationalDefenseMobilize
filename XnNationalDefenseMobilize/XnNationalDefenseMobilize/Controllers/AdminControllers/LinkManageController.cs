using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Master;
using XnNationalDefenseMobilize.Models.Slogan;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class LinkManageController : Controller
    {
        private LinkListContext linkListContext = new LinkListContext();

        //
        // GET: /LinkManage/
        [Authorize]
        public ActionResult Index()
        {
            return View(linkListContext);
        }

        //删除
        // id为要删除的建议的id
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            LinkList linkList = linkListContext.linkLists.Find(id);
            linkListContext.linkLists.Remove(linkList);
            linkListContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            LinkList linkList = null;
            String linkIds = Request.Form["linkid"];
            String[] ids = linkIds.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                linkList = linkListContext.linkLists.Find(int.Parse(ids[i]));
                linkListContext.linkLists.Remove(linkList);
                linkListContext.SaveChanges();
            }
            return Content("删除成功");
        }

        //添加链接
        [Authorize]
        [HttpPost]
        public ActionResult AddLink(String LinkName, String LinkAddress)
        {
            LinkList linkList = new LinkList();
            linkList.link_name = LinkName;
            linkList.link_url = LinkAddress;

            if(ModelState.IsValid){
                linkListContext.linkLists.Add(linkList);
                linkListContext.SaveChanges();
            }
            return Content("添加成功");
        }

        //修改链接
        [Authorize]
        [HttpPost]
        public ActionResult ModifyLink()
        {
            LinkList linkList = new LinkList();
            linkList.link_id = int.Parse(Request.Form["link_id"]);
            linkList.link_name = Request.Form["newLinkName"];
            linkList.link_url = Request.Form["newLinkAddress"];
            if(ModelState.IsValid){
                linkListContext.Entry(linkList).State = EntityState.Modified;
                linkListContext.SaveChanges();
            }
            return Content("修改成功");
        }

        //搜索
        [Authorize]
        [HttpPost]
        public ActionResult Search()
        {
            //搜索方式
            //by_id:按id
            //by_name:按时间
            String s_type = Request.Form["s_type"];
            String s_text = Request.Form["s_text"];
            return Content("搜索成功:" + s_text);
        }
    }
}
