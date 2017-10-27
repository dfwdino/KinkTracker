using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web;

namespace Web.Areas.Admin
{
    public class PagedViewsController : Controller
    {
        private KinkTrackerEntities db = new KinkTrackerEntities();

        // GET: Admin/PagedViews
        public ActionResult Index()
        {
            return View(db.PagedViews.ToList());
        }

        // GET: Admin/PagedViews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PagedView pagedView = db.PagedViews.Find(id);
            if (pagedView == null)
            {
                return HttpNotFound();
            }
            return View(pagedView);
        }

        // GET: Admin/PagedViews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PagedViews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,IPAddress,ControllerName,ActionName,ActionParameters,AbsoluteUri,Notes")] PagedView pagedView)
        {
            if (ModelState.IsValid)
            {
                db.PagedViews.Add(pagedView);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagedView);
        }

        // GET: Admin/PagedViews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PagedView pagedView = db.PagedViews.Find(id);
            if (pagedView == null)
            {
                return HttpNotFound();
            }
            return View(pagedView);
        }

        // POST: Admin/PagedViews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,IPAddress,ControllerName,ActionName,ActionParameters,AbsoluteUri,Notes")] PagedView pagedView)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagedView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagedView);
        }

        // GET: Admin/PagedViews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PagedView pagedView = db.PagedViews.Find(id);
            if (pagedView == null)
            {
                return HttpNotFound();
            }
            return View(pagedView);
        }

        // POST: Admin/PagedViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PagedView pagedView = db.PagedViews.Find(id);
            db.PagedViews.Remove(pagedView);
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
