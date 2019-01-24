using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFBll;

namespace efbLL.Tests
{
    [TestClass()]
    public class UserInfoBllTests
    {
        [TestMethod()]
        public void AddTest()
        {
            UserInfo userInfo = new UserInfo() { Age = 12,CrUserName = "",UserLoginName = "lizj",UserName= "李中建", CrDate=DateTime.Now,IsOnLine=0,IsUseful=1,IsVip =1,UserMail="153126453@qq.com" ,CrUserRealName="李中建",UserPsd = "1234567890",UserRealName = "李中建"};


            UserInfoBll userInfoBll = new UserInfoBll();
            if (userInfoBll.Add(userInfo))
            {

            }
            else
            {
                Assert.Fail();
            }
          
        }


        [TestMethod]
        public void AddUserInfo()
        {
            UserInfo userInfo = new UserInfo() { Age = 12, CrUserName = "", UserLoginName = "lizj", UserName = "李中建", CrDate = DateTime.Now, IsOnLine = 0, IsUseful = 1, IsVip = 1, UserMail = "153126453@qq.com", CrUserRealName = "李中建", UserPsd = "1234567890", UserRealName = "李中建" };

            UserInfoBll userInfoService = new UserInfoBll();
            if (userInfoService.Add(userInfo))
            {
            }
            else
            {
                Assert.Fail();
            }

        }


        [TestMethod]

        public void GetUserInfos()
        {
            UserInfoBll userInfoService = new UserInfoBll();
            var users = userInfoService.GetEntities(u => u.Age > 10);
            if (users.Count() > 0 ? true : false)
            {
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void AddUserMag()
        {
            UserMsgService userMsgService = new UserMsgService();

            UserMSG userMSG = new UserMSG() { address = "ads", username = "qeqw", departmentid = "22", userid = 11 };

            if (userMsgService.Add(userMSG))
            {
            }
            else
            {
                Assert.Fail();
            }
           
        }
        [TestMethod]

        public void GetNews()
        {
            NewsService newsService = new NewsService();
            var newsList = newsService.GetEntities(n => true);
            if (newsList.Count() > 0)
            {
                foreach (var item in newsList)
                {

                    new News() { Author = item.Author, NewsMsg = item.NewsMsg };
                }
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}