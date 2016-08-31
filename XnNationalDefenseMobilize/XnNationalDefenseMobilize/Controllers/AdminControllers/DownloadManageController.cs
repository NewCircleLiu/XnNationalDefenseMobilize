using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XnNationalDefenseMobilize.Controllers.BackControllers
{
    public class DownloadManageController : Controller
    {
        //
        // GET: /DownloadManage/

        public ActionResult Index()
        {
            return View();
        }

        //刷新
        [HttpPost]
        public ActionResult Refresh(String model_id)
        {
            //model_id:为要刷新的模块名称，file_model:文件模块，phone_app:手机app模块,pc:pc应用模块，book:图书模块
            return Content("刷新成功:" + model_id);
        }

        //删除
        [HttpPost]
        public ActionResult Delete(String id)
        {
            //id:为要删除的资源的id，根据id来判断资源的类别，例如1001,2001,3001,4001,根据id第一个数字分别为：文件，手机app，pc应用，图书
            return Content("删除成功:"+id);
        }

        //批量删除
        [HttpPost]
        public ActionResult DeleteMore()
        {
            //id:为要删除的资源的id，根据id来判断资源的类别，例如1001,2001,3001,4001,根据id第一个数字分别为：文件，手机app，pc应用，图书
            String newsid = Request.Form["news"];  //多个id拼接成字符串：“1001,1002,1003”
            return Content("删除成功:" + newsid);
        }

        //搜索
        [HttpPost]
        public ActionResult Search()
        {
            //搜索模块
            //file_search:
            //pc_search:
            //phone_search:
            //book_search:
            String model = Request.Form["model"];
            //搜索方式
            //by_id:
            //by_name:
            String s_type = Request.Form["s_type"];
            //搜索内容
            String s_text = Request.Form["s_text"];

            return Content("删除成功:" + s_text);
        }

        //上传
        [HttpPost]
        public ActionResult Upload() {

            //文件名称
            String fileName = Request.Form["fileName"];
            //文件类别
            //f_file:
            //f_app:
            //f_pc:
            //f_book:
            String classify = Request.Form["classify"];
            //文件路径
            String fileUrl = Request.Form["fileUrl"];

            return Content("上传成功:" + fileName);
        }
    }
}
