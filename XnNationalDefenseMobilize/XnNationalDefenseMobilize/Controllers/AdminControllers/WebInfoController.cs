using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.Master;

namespace XnNationalDefenseMobilize.Controllers.AdminControllers
{
    public class WebInfoController : Controller
    {
        //
        // GET: /WebInfo/

        ContactContext contactContext = new ContactContext();

        public ActionResult Index()
        {
            Contact contact = contactContext.ContactLists.Find(1);
            return View(contact);
        }

        //修改信息
        [HttpPost]
        public ActionResult ModifyInfo()
        {
            Contact contact = new Contact();

            contact.contact_id = 1;
            contact.contact_addr = Request.Form["address"];
            contact.contact_phone = Request.Form["phone"];
            contact.contact_fax = Request.Form["fax"];
            contact.contact_email = Request.Form["email"];
            contact.contact_website = Request.Form["webSite"];
            contact.contact_wx_bincode = Request.Form["wx_bincode"];
            contact.contact_web_bincode = Request.Form["web_bincode"];

            if (ModelState.IsValid)
            {
                contactContext.Entry(contact).State = EntityState.Modified;
                contactContext.SaveChanges();
            }

            return Content("修改成功:");
        }

    }
}
