
using efbLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebEFTest0806.Controllers
{
    public class NewsController : Controller
    {
        // GET: News

        NewsService newsService = new NewsService();
        public ActionResult Index()
        {
            //   newsService.Add( new News() {Author="hello",SubTime=DateTime.Now.ToString(),ImagePath="www",NewsMsg="hi，啥啥啥",Title="哈哈" } );

            //  return Content("Ok");

            // return newsService.GetEntities(u => true).ToList(); 
            List < News > newsList  = newsService.GetEntities(n => true) as List<News>;


            ViewData["newsList"] = newsList;
            return View();
        }
    }
}