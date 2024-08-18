using MVC5BlogProjectNTier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;

namespace MVC5BlogProjectNTier.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizeResult()
        {

            return Json(CategoryList(), JsonRequestBehavior.AllowGet);
        }


        public List<Class1> CategoryList()
        {
            List<Class1> c = new List<Class1>();
            c.Add(new Class1()
            {
                CategoryName = "Teknoloji",
                BlogCount = 14
            });

            c.Add(new Class1()
            {
                CategoryName = "Spor",
                BlogCount = 14
            });
            c.Add(new Class1()
            {
                CategoryName = "Kitap",
                BlogCount = 16
            });

            return c;

        }

        public List<Class2> Bloglist()
        {
            List<Class2> cs2=new List<Class2>();
            using (var c=new Context())
            {
                cs2=c.Blogs.Select(x=>new Class2
                {
                    BlogName=x.BlogTitle,
                    BlogRating=x.BlogRating,
                }).ToList();

                
            }
            return cs2;
        }
        public ActionResult VisualizeResult2()
        {

            return Json(Bloglist(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Chart1()
        {
            return View();
        }
        public ActionResult Chart2()
        {
            return View();
        }
    }
}