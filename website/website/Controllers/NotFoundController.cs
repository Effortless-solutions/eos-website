using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Content
{
    public class NotFoundController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}