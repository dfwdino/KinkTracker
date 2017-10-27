using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
        
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {

            KinkTrackerEntities kte = new KinkTrackerEntities();

            User foundUser = kte.Users.Where(m => m.KinkName == user.KinkName && m.Password == user.Password).FirstOrDefault();

            if (foundUser != null) {
            
            if(user.Schema.Role.Equals("Admin"))
                RedirectToRoute("", "");
            else if(user.KinkRole.Role.Equals("Dom"))
                RedirectToRoute("", "");
            else if (user.KinkRole.Role.Equals("Sub"))
                RedirectToRoute("", "");

            }

            throw new HttpException("Can't find user.");

            return View(user);
        }

    }
}