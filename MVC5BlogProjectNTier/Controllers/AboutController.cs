using BussinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5BlogProjectNTier.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutManager = new AboutManager();
        public ActionResult Index()
        {
            var aboutContent = aboutManager.GetAll();

            return View(aboutContent);
        }
        public PartialViewResult Footer()
        {

            var aboutcontentList=aboutManager.GetAll();


            return PartialView(aboutcontentList);
        }

        public PartialViewResult MeetTheTeam()
        {
            AuthorManager autman=new AuthorManager();

            var authorList=autman.GetAll();

            return PartialView(authorList);
        }
        [HttpGet]
        public ActionResult UpdateAbout()
        {
            var aboutList=aboutManager.GetAll();

            return View(aboutList);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            aboutManager.UpdateAboutBM(p);

            return RedirectToAction("UpdateAbout");
        }
    }
}