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
    public class SchemasController : Controller
    {
        private KinkTrackerEntities db = new KinkTrackerEntities();

        // GET: Admin/Schemas
        public ActionResult Index()
        {
            return View(db.Schemas.ToList());
        }

        // GET: Admin/Schemas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schema schema = db.Schemas.Find(id);
            if (schema == null)
            {
                return HttpNotFound();
            }
            return View(schema);
        }

        // GET: Admin/Schemas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Schemas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LogID,Role")] Schema schema)
        {
            if (ModelState.IsValid)
            {
                db.Schemas.Add(schema);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schema);
        }

        // GET: Admin/Schemas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schema schema = db.Schemas.Find(id);
            if (schema == null)
            {
                return HttpNotFound();
            }
            return View(schema);
        }

        // POST: Admin/Schemas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LogID,Role")] Schema schema)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schema).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schema);
        }

        // GET: Admin/Schemas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schema schema = db.Schemas.Find(id);
            if (schema == null)
            {
                return HttpNotFound();
            }
            return View(schema);
        }

        // POST: Admin/Schemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Schema schema = db.Schemas.Find(id);
            db.Schemas.Remove(schema);
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
