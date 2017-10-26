using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using Web;


namespace web.Controllers
{
    public class PageViewAttribute : ActionFilterAttribute
    {
        private static readonly TimeSpan pageViewDumpToDatabaseTimeSpan = new TimeSpan(0, 0, 10);
        

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            KinkTrackerEntities db = new KinkTrackerEntities();

            PagedView myLogging = new PagedView();

            myLogging.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            myLogging.ActionName = filterContext.ActionDescriptor.ActionName;
            myLogging.Date = filterContext.HttpContext.Timestamp;
            myLogging.IPAddress = filterContext.HttpContext.Request.UserHostAddress;
            myLogging.ActionParameters = "";

            myLogging.AbsoluteUri = filterContext.HttpContext.Request.UrlReferrer?.AbsoluteUri;


            foreach (var pram in filterContext.ActionParameters)
            {
                myLogging.ActionParameters += pram + " ";
            }

            myLogging.ActionParameters = myLogging.ActionParameters.Trim();

            db.PagedViews.Add(myLogging);
            try
            {
                db.SaveChanges();
            }
            catch
            {
                return;

            }

        }

        private static void onRemove(string key, object value, CacheItemRemovedReason reason)
        {
            if (!key.StartsWith("PV-"))
            {
                return;
            }

            KinkTrackerEntities db = new KinkTrackerEntities();

            PagedView myLogging = new PagedView();

            string[] keyValues = key.Replace("PV-", "").Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

            myLogging.ControllerName = keyValues[0];
            myLogging.ActionName = keyValues[1];
            myLogging.Date = DateTime.Now;


            db.PagedViews.Add(myLogging);
            db.SaveChanges();


        }

        // Used to get around weird cache behavior with value types
        public class PageViewValue
        {
            public PageViewValue()
            {
                Value = 1;
            }

            public int Value { get; set; }
        }
    }
}