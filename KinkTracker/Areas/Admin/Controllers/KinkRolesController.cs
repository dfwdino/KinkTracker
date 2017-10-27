using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web;

namespace Web.Areas.Admin.Controllers
{
    public class KinkRolesController : Controller
    {
        private KinkTrackerEntities db = new KinkTrackerEntities();

        // GET: Admin/KinkRoles
        public ActionResult Index()
        {
            return View(db.KinkRoles.ToList());
        }

        // GET: Admin/KinkRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KinkRole kinkRole = db.KinkRoles.Find(id);
            if (kinkRole == null)
            {
                return HttpNotFound();
            }
            return View(kinkRole);
        }

        // GET: Admin/KinkRoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KinkRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LogID,Role")] KinkRole kinkRole)
        {
            if (ModelState.IsValid)
            {
                db.KinkRoles.Add(kinkRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kinkRole);
        }

        // GET: Admin/KinkRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KinkRole kinkRole = db.KinkRoles.Find(id);
            if (kinkRole == null)
            {
                return HttpNotFound();
            }
            return View(kinkRole);
        }

        // POST: Admin/KinkRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LogID,Role")] KinkRole kinkRole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kinkRole).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kinkRole);
        }

        // GET: Admin/KinkRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KinkRole kinkRole = db.KinkRoles.Find(id);
            if (kinkRole == null)
            {
                return HttpNotFound();
            }
            return View(kinkRole);
        }

        // POST: Admin/KinkRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KinkRole kinkRole = db.KinkRoles.Find(id);
            db.KinkRoles.Remove(kinkRole);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
