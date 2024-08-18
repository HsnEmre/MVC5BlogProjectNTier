using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC5BlogProjectNTier.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AuthorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            Context c = new Context();
            var userInfo = c.Authors.FirstOrDefault(x => x.AuthorMail == p.AuthorMail && x.Password == p.Password);

            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.AuthorMail, false);
                Session["Mail"] = userInfo.AuthorMail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }

            return View();
        }


        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            Context c = new Context();
            var userInfo = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);

            if (userInfo != null)
            {
                FormsAuthentication.SetAuthCookie(userInfo.UserName, false);
                Session["UserName"] = userInfo.UserName.ToString();
                return RedirectToAction("AdminBlogList", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }

            return View();
        }

    }
}