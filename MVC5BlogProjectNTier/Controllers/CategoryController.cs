using BussinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5BlogProjectNTier.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryValues = cm.GetAll();
            return View(categoryValues);
        }
        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = cm.GetAll();
            return PartialView(categoryValues);
        }

        public ActionResult AdminCategoryList()
        {
            var categoryList = cm.GetAll();

            return View(categoryList);
        }
        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Categories c)
        {
            cm.CategoryAddBBL(c);
            return RedirectToAction("AdminCategoryList");
        }


        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {

            Categories category = cm.FindCategory(id);

            return View(category);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Categories p)
        {
            cm.EditCategory(p);

            return RedirectToAction("AdminCategoryList");
        }

        public ActionResult CategoryDelete(int id)
        {
            cm.DeleteCategoryBL(id);
            return RedirectToAction("AdminCategoryList");
        }

        public ActionResult CategoryStatusTrue(int id)
        {
            cm.DeleteStatusTrueBL(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}