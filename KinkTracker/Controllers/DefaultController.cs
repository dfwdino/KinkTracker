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

            if (foundUser != null)
            {
                if (foundUser.Schema.Role.Equals("Admin"))
                    return RedirectToAction("Index","Default", new { area = "Admin", id=foundUser.ID});
                else if (foundUser.KinkRole.Role.Equals("Dom"))
                    return RedirectToAction("Index", "Default",new { area = "Dom", id = foundUser.ID });
                else if (foundUser.KinkRole.Role.Equals("Sub"))
                    return RedirectToAction("Index", "Default", new { area = "Sub", id = foundUser.ID });
            }

            ModelState.AddModelError("KinkName", "Can not find user or password is invalid.");
            
            return View(foundUser);
        }

    }
}