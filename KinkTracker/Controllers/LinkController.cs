using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LinkController : Controller
    {
        // GET: Link
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchuser)
        {
            KinkTrackerEntities kte = new KinkTrackerEntities();

            User user = kte.Users.Where(m => m.KinkName == searchuser).FirstOrDefault();

            if (user == null)
                return View();

            UserOwner UO = new UserOwner();

            switch (user.KinkRole.Role)
            {
                case "Dom":
                    UO.DomID = user.ID;
                    UO.SubID = 1;//Get Current user
                    break;
                case "Sub":
                    UO.SubID = user.ID;
                    UO.DomID = 1;//Get Current user
                    break;
                default:
                    break;
            }

            kte.UserOwners.Add(UO);
            kte.SaveChanges();

            return View("Invite Sent if user is valid.");
        }
    }
}