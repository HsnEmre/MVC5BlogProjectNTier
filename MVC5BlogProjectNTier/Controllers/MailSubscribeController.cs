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
    public class MailSubscribeController : Controller
    {
        // GET: MailSubscribe
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }

        [HttpPost]
       
        public PartialViewResult AddMail(SubscribeMail parameter)
        {
            SubscribeMailManager mailManager = new SubscribeMailManager();
            mailManager.BLAdd(parameter);
            return PartialView();
        }
    }
}