using System;
using System.Web;

namespace Web.Content
{
    public class Logger
    {
        public int CreateLog(int userID,string useragent,double? lat,double? lon){
            KinkTrackerEntities kte = new KinkTrackerEntities();

            Log log = new Log();

            log.CreatedOn = DateTime.Now;
            log.CreateByID = 0;
            log.Broswer = useragent;
            log.Lat = lat;
            log.Long = lon;
            log.IPAddress = System.Web.HttpContext.Current.Request.UserHostAddress;

            kte.Logs.Add(log);
            kte.SaveChanges();

            return log.ID;
        }

    }
}