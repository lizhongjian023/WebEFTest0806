using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebEFTest0806.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 弱类型的数据传递
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShowInfo(int id)
        {
            UserInfo info = new UserInfo() { Age = 22, Id = id, IsUseful = 1, IsVip = 1, UserMail = "312213@qq.com", UserName = "熊明", UserPsd = "222", UserRealName = "佛山市" };

            ViewData["info"] = info;

            return View();
        }

       
    }
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserLoginName { get; set; }
        public Nullable<int> IsVip { get; set; }
        public Nullable<int> IsOnLine { get; set; }
        public Nullable<System.DateTime> CrDate { get; set; }
        public string CrUserName { get; set; }
        public string CrUserRealName { get; set; }
        public Nullable<System.DateTime> MoDate { get; set; }
        public string MoUserRealName { get; set; }
        public string MoUserName { get; set; }
        public Nullable<int> Age { get; set; }
        public string UserPsd { get; set; }
        public Nullable<int> IsUseful { get; set; }
        public string UserRealName { get; set; }
        public string UserMail { get; set; }
        public int Id { get; set; }
    }
}