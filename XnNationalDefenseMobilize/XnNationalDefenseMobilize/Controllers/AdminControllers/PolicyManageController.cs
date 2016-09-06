using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XnNationalDefenseMobilize.Models.PolycyAdvice;
using XnNationalDefenseMobilize.Models.utility;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class PolicyManageController : Controller
    {
        private CommonQuesContext commonQuesContext = new CommonQuesContext();
        private MessageContext messageContext = new MessageContext();
        //
        // GET: /PolicyManage/

        [Authorize]
        public ActionResult Index(int page_id = 1)
        {
            IEnumerable<CommonQues> questionList = commonQuesContext.commonQuesLists.ToList();
            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(questionList, 12, 5, page_id);
            return View(multiPagesContrler);
        }

        public ActionResult PublishNewsPage()
        {
            return View();
        }

        //发布
        [Authorize]
        [HttpPost]
        public ActionResult PublishNews()
        {
            CommonQues c = new CommonQues();
            c.question_content = Request.Form["question"];
            c.question_release_time = DateTime.Now;

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            c.question_answer = text;

            if (ModelState.IsValid)
            {
                commonQuesContext.commonQuesLists.Add(c);
                commonQuesContext.SaveChanges();
            }
            return Content("发布成功");
        }

        //修改页面
        [Authorize]
        [HttpGet]
        public ActionResult ModifyPage(int id)
        {
            CommonQues c = commonQuesContext.commonQuesLists.Find(id);
            return View(c);
        }

        //修改
        [Authorize]
        [HttpPost]
        public ActionResult Modify()
        {
            CommonQues c = new CommonQues();
            c.question_content = Request.Form["question"];
            c.question_release_time = DateTime.Now;
            c.question_id = int.Parse(Request.Form["id"]);

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");
            c.question_answer = text;

            if (ModelState.IsValid)
            {
                commonQuesContext.Entry(c).State = EntityState.Modified;
                commonQuesContext.SaveChanges();
            }
            return Content("修改成功");
        }

        //删除常见问题
        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            CommonQues c = commonQuesContext.commonQuesLists.Find(id);
            commonQuesContext.commonQuesLists.Remove(c);
            commonQuesContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除常见问题
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMore()
        {
            CommonQues c = null;
            String data = Request.Form["CommonQuize"];
            String[] ids = data.Split(',');
            for (int i = 0; i < ids.Length;i++ )
            {
                c = commonQuesContext.commonQuesLists.Find(int.Parse(ids[i]));
                commonQuesContext.commonQuesLists.Remove(c);
                commonQuesContext.SaveChanges();
            }
            return Content("删除成功" );
        }

        //留言页面
        [Authorize]
        [HttpGet]
        public ActionResult ReplayPage(int page_id = 1)
        {
            IEnumerable<Message> messageList = messageContext.messageLists.ToList();
            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(messageList, 12, 5, page_id);
            return View(multiPagesContrler);
        }

        //修改回复页面
        [Authorize]
        [HttpGet]
        public ActionResult ModifyMessagePage(int id)
        {
            Message m = messageContext.messageLists.Find(id);
            return View(m);
        }

        //修改回复
        [Authorize]
        [HttpPost]
        public ActionResult ModifyMessage()
        {
            int id = int.Parse(Request.Form["id"]);
            Message m = messageContext.messageLists.Find(id);

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");

            m.message_reply_content = text;

            if (ModelState.IsValid)
            {
                messageContext.Entry(m).State = EntityState.Modified;
                messageContext.SaveChanges();
            }
            return Content("修改成功");
        }

        //回复页面
        [Authorize]
        [HttpGet]
        public ActionResult AnswerPage(int id)
        {
            Message m = messageContext.messageLists.Find(id);
            return View(m);
        }



        //回复留言
        [Authorize]
        [HttpPost]
        public ActionResult ReplayMessage()
        {
            int id = int.Parse(Request.Form["id"]);
            Message m = messageContext.messageLists.Find(id);

            String text = Request.Form["text"];
            text = text.Replace("#lt;", "<");
            text = text.Replace("#gt;", ">");

            m.message_reply_content =  text;

            if (ModelState.IsValid)
            {
                messageContext.Entry(m).State = EntityState.Modified;
                messageContext.SaveChanges();
            }
            return Content("回复成功");
        }

        //删除留言
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMessage(int id)
        {
            Message m = messageContext.messageLists.Find(id);
            messageContext.messageLists.Remove(m);
            messageContext.SaveChanges();
            return Content("删除成功");
        }

        //批量删除留言
        [Authorize]
        [HttpPost]
        public ActionResult DeleteMoreMessage()
        {
            Message m = null;
            String data = Request.Form["message"];
            String[] ids = data.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                m = messageContext.messageLists.Find(int.Parse(ids[i]));
                messageContext.messageLists.Remove(m);
                messageContext.SaveChanges();
            }
            return Content("删除成功");
        }

        //搜索
        [Authorize]
        [HttpPost]
        public ActionResult Search()
        {
            //搜索方式
            //by_name:按名称
            //by_type:按类型
            String s_type = Request.Form["s_type"];
            String s_text = Request.Form["s_text"];
            //模块名称
            String model = Request.Form["model"];
            return Content("搜索成功:" + model);
        }
    }
}
