using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Areas.Sub.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Sub/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}