using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAjax.Models;
using System.Web.Mvc;

namespace TestAjax.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult SearchBooks (string name)
        {
            var allBooks = db.Books.Where(b => b.Author.Contains(name)).ToList();
            if (allBooks.Count <=0)
            {
                return HttpNotFound();
            }
            return PartialView(allBooks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}