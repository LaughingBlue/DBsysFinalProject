using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


    namespace DBsysFinalProject.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "DataBase Final Project Team.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "聯絡方式.";

            return View();
        }

        //[Route("search", Name = HomeControllerRoute.GetSearch)]
        //public ActionResult Search(string query)
        //{
        //    // You can implement a proper search function here and add a Search.cshtml page.
        //    // return this.View(HomeControllerAction.Search);

        //    // Or you could use Google Custom Search (https://cse.google.co.uk/cse) to index your site and display your 
        //    // search results in your own page.

        //    // For simplicity we are just assuming your site is indexed on Google and redirecting to it.
        //    return this.Redirect(string.Format(
        //        "https://www.google.co.uk/?q=site:{0} {1}",
        //        this.Url.AbsoluteRouteUrl(HomeControllerRoute.GetIndex),
        //        query));
        //}
    }
}