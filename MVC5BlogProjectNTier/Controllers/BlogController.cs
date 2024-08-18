using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5BlogProjectNTier.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogmanager = new BlogManager();


        // GET: Blog
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        #region BlogList

        [AllowAnonymous]
        public PartialViewResult BlogList(int page = 1)
        {
            var blogllist = blogmanager.GetAll().ToPagedList(page, 6);

            return PartialView(blogllist);
        }
        #endregion
        [AllowAnonymous]
        public PartialViewResult FeaturedPost()
        {
            #region Post1
            //1. post
            var posttitle1 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 1)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle)
                .FirstOrDefault();

            // post img1 
            var postimg1 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 1)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogImage)
                .FirstOrDefault();

            //blogdate1
            var postdate1 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 1)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogDate)
                .FirstOrDefault();
            //blogpostıd
            var blogpostid1 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 1)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogID)
                .FirstOrDefault();


            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimg1 = postimg1;
            ViewBag.postdate1 = postdate1;
            ViewBag.blogpostid1 = blogpostid1;

            #endregion

            #region Post2
            //1. post
            var posttitle2 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 2)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle)
                .FirstOrDefault();

            // post img1 
            var postimg2 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 2)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogImage)
                .FirstOrDefault();

            //blogdate1
            var postdate2 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 2)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogDate)
                .FirstOrDefault();
            //blogpostıd
            var blogpostid2 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 2)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogID)
                .FirstOrDefault();

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimg2 = postimg2;
            ViewBag.postdate2 = postdate2;
            ViewBag.blogpostid2 = blogpostid2;

            #endregion

            #region Post3
            //1. post
            var posttitle3 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 3)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle)
                .FirstOrDefault();

            // post img1 
            var postimg3 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 3)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogImage)
                .FirstOrDefault();

            //blogdate1
            var postdate3 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 3)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogDate)
                .FirstOrDefault();
            //blogpostıd
            var blogpostid3 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 3)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogID)
                .FirstOrDefault();

            
            ViewBag.blogpostid3 = blogpostid3;
            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimg3 = postimg3;
            ViewBag.postdate3 = postdate3;

            #endregion

            #region Post4
            //1. post
            var posttitle4 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 4)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle)
                .FirstOrDefault();

            // post img1 
            var postimg4 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 4)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogImage)
                .FirstOrDefault();

            //blogdate1
            var postdate4 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 4)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogDate)
                .FirstOrDefault();

            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimg4 = postimg4;
            ViewBag.postdate4 = postdate4;
            //blogpostıd
            var blogpostid4 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 4)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogID)
                .FirstOrDefault();

            ViewBag.blogpostid2 = blogpostid4;

            #endregion

            #region Post4
            //1. post
            var posttitle5 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 5)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogTitle)
                .FirstOrDefault();

            // post img1 
            var postimg5 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 5)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogImage)
                .FirstOrDefault();

            //blogdate1
            var postdate5 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 5)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogDate)
                .FirstOrDefault();

            ViewBag.posttitle5 = posttitle5;
            ViewBag.postimg5 = postimg5;
            ViewBag.postdate5 = postdate5;
            //blogpostıd
            var blogpostid5 = blogmanager.GetAll()
                .Where(x => x.CategoryID == 5)
                .OrderByDescending(x => x.BlogID)
                .Select(x => x.BlogID)
                .FirstOrDefault();

            
            ViewBag.blogpostid5 = blogpostid5;

            #endregion

            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult OtherFuturedPost()
        {
            return PartialView();
        }


        [AllowAnonymous]
        public ActionResult BlogDetails()
        {

            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogCover(int id)
        {
            var blogdetaillist = blogmanager.GetBlogById(id);

            return PartialView(blogdetaillist);
        }
        [AllowAnonymous]
        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = blogmanager.GetBlogById(id);
            return PartialView(BlogDetailsList);
        }
        [AllowAnonymous]
        public ActionResult BlogByCategory(int id)
        {
            var BlogListByCategory = blogmanager.GetBlogById(id);

            var categoryname = blogmanager.GetBlogById(id).Select(x => x.Categories.CategoryName).FirstOrDefault();
            ViewBag.categoryName = categoryname;

            var categoryDesc = blogmanager.GetBlogById(id).Select(x => x.Categories.CategoryDescription).FirstOrDefault();
            ViewBag.categorydesc = categoryDesc;

            return View(BlogListByCategory);
        }
       
        public ActionResult AdminBlogList()
        {
            var bloglist = blogmanager.GetAll();

            return View(bloglist);
        }

        public ActionResult AdminBlogList2()
        {
            var bloglist = blogmanager.GetAll();
            return View(bloglist);
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

            return RedirectToAction("AdminBlogList");
        }


        public ActionResult DeleteBlog(int id)
        {
            blogmanager.DeleteBlogBL(id);
            return RedirectToAction("AdminBlogList");
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
            return RedirectToAction("AdminBlogList");
        }

        public ActionResult GetCommentById(int id)
        {
            CommentManager cm = new CommentManager();
            var commentList = cm.CommentByBlog(id);
            return View(commentList);
        }

        [AllowAnonymous]
        public ActionResult AuthorBogList(int id)
        {
            
            var Blogs = blogmanager.GetblogByauthor(id);
            return View(Blogs);
        }


    }
}