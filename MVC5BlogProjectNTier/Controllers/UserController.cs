using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebGrease;

namespace MVC5BlogProjectNTier.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager userProfileManager = new UserProfileManager();
        BlogManager blogmanager = new BlogManager();
        public ActionResult Index()
        {


            return View();
        }

        public PartialViewResult Partial1(string mail)
        {
            mail = (string)Session["Mail"];

            var profileValues = userProfileManager.GetAuthorByMail(mail);
            return PartialView(profileValues);
        }

        public ActionResult UpdateUserProfile(Author p)
        {
            userProfileManager.EditAuthor(p);
            return RedirectToAction("Index");
        }

        public ActionResult BogList(string p)
        {

            p = (string)Session["Mail"];
            Context c = new Context();
            int id = c.Authors.Where(x => x.AuthorMail == p).Select(y => y.AuthorID).FirstOrDefault();

            var Blogs = userProfileManager.GetBlogByAuthor(id);
            return View(Blogs);
        }


        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = blogmanager.FindBlog(id);

            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            ViewBag.val = values;


            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorNameSurname,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.val2 = values2;


            return View(blog);
        }


        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            blogmanager.UpdateBlog(p);
            return RedirectToAction("BogList");
        }


        [HttpGet]
        public ActionResult AddNewBlog()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();

            ViewBag.val = values;


            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorNameSurname,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.val2 = values2;


            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog bloginstance)
        {
            blogmanager.BlogAddBL(bloginstance);

            return RedirectToAction("BogList");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AuthorLogin", "Login");
        }

    }
}