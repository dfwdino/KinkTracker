using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Areas.Dom.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Dom/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}