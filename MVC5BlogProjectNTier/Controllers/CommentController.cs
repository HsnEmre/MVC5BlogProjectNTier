using BussinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5BlogProjectNTier.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment

        CommentManager commandmanager = new CommentManager();
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var commentlist = commandmanager.CommentByBlog(id);
            return PartialView(commentlist);

        }
        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult LeaveAComment( int id)
        {
            ViewBag.id=id;
            return PartialView();
        }

        [HttpPost]
        [AllowAnonymous]
        public PartialViewResult LeaveAComment(Comments c)
        {
            c.CommentStatus = true;
            commandmanager.CommentAdd(c);
            return PartialView();
        }

        public ActionResult AdminCommentListTrue()
        {
            var comment_List= commandmanager.CommentByStatusTrue();

            return View(comment_List);
        }

        public ActionResult CommentStatusChangeToFalseAction(int id)
        {
            commandmanager.ChangeCommentStatusToFalse(id);

            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult CommentStatusChangeToTrueAction(int id)
        {
            commandmanager.ChangeCommentStatusToFalse(id);

            return RedirectToAction("AdminCommentListFalse");
        }

        public ActionResult AdminCommentListFalse()
        {
            var commentList = commandmanager.CommentStatusFalse();
            return View(commentList);
        }

    }
}