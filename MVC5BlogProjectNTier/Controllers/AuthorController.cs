using BussinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5BlogProjectNTier.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager blogManager = new BlogManager();
        AuthorManager authorManager = new AuthorManager();
        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = blogManager.GetBlogById(id);

            return PartialView(authordetail);
        }
        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogAuthorId = blogManager.GetAll().Where(x => x.BlogID == id)
                .Select(y => y.AuthorID).FirstOrDefault();
            //ViewBag.blogauthorid=blogAuthorId;

            var authorBlogs = blogManager.GetblogByauthor(blogAuthorId);

            return PartialView(authorBlogs);
        }

        public ActionResult AuthorList()
        {
            var authorLists = authorManager.GetAll();

            return View(authorLists);
        }
        [HttpGet]
        public ActionResult addAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addAuthor(Author parameter)
        {
            authorManager.AddAuthorBL(parameter);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {

            Author author = authorManager.FindAuthor(id);

            return View(author);
        }
        
        public ActionResult AuthorEdit(Author p)
        {
            authorManager.EditAuthor(p);

            return RedirectToAction("AuthorList");
        }

    }
}