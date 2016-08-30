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
            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(questionList, 12, 5, page_id);
            return View(multiPagesContrler);
        }

        public ActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quiz(string test)
        {
            Message message = new Message();
            message.message_username = Request["name"];
            message.message_email = Request["email"];
            message.message_title = Request["title"];
            message.message_content = Request["answer"];

            MessageContext messageContext = new MessageContext();
            messageContext.messageLists.Add(message);
            messageContext.SaveChanges();

            return View();
        }

        public ActionResult Reply(int page_id = 1)
        {
            MessageContext messageContext = new MessageContext();
            IEnumerable<Message> messageList = messageContext.messageLists.ToList();
            MulltiPageDisplayContrler multiPagesContrler = new MulltiPageDisplayContrler(messageList, 12, 5, page_id);
            return View(multiPagesContrler);
        }

        public ActionResult ReplyDetail(int id)
        {
            MessageContext messageContext = new MessageContext();
            Message singleMessage = messageContext.messageLists.Find(id);
            return View(singleMessage);
        }

        public ActionResult CommonQuesDetail(int id)
        {
            CommonQuesContext commonQuesContext = new CommonQuesContext();
            CommonQues singleCommonQues = commonQuesContext.commonQuesLists.Find(id);
            return View(singleCommonQues);
        }
    }
}
