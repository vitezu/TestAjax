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
            ViewBag.Authors = db.Books.Select(a => a.Author).Distinct();
            return View();
        }

        public JsonResult JsonSearch (string name)
        {
            var data = db.Books.Where(b => b.Author == name).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
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

        public ActionResult Bestbook()
        {
            Book book = db.Books.First();
            return PartialView(book);
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