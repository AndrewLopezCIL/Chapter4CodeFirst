using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Chapter4CodeFirst.DAL;
using Chapter4CodeFirst.Models;

namespace Chapter4CodeFirst.Controllers
{
    public class VRHeadsetModelsController : Controller
    {
        private VRContext db = new VRContext();

        // GET: VRHeadsetModels
        public ActionResult Index()
        {
            return View(db.VRHeadsetModels.ToList());
        }
        public ActionResult EditDisplay(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VRHeadsetModels vRHeadsetModels = db.VRHeadsetModels.Find(id);
            if (vRHeadsetModels == null)
            {
                return HttpNotFound();
            }
            return View(vRHeadsetModels);
        }

        // POST: VRHeadsetModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDisplay([Bind(Include = "HeadsetID,Price,AvailableStoreName,HeadsetName")] VRHeadsetModels vRHeadsetModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vRHeadsetModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vRHeadsetModels);
        }
        
        public ActionResult Display()
        {
            return View(db.VRHeadsetModels.ToList());
        }

        // GET: VRHeadsetModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VRHeadsetModels vRHeadsetModels = db.VRHeadsetModels.Find(id);
            if (vRHeadsetModels == null)
            {
                return HttpNotFound();
            }
            return View(vRHeadsetModels);
        }

        // GET: VRHeadsetModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VRHeadsetModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HeadsetID,Price,AvailableStoreID,HeadsetName")] VRHeadsetModels vRHeadsetModels)
        {
            if (ModelState.IsValid)
            {
                db.VRHeadsetModels.Add(vRHeadsetModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vRHeadsetModels);
        }

        // GET: VRHeadsetModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VRHeadsetModels vRHeadsetModels = db.VRHeadsetModels.Find(id);
            if (vRHeadsetModels == null)
            {
                return HttpNotFound();
            }
            return View(vRHeadsetModels);
        }

        // POST: VRHeadsetModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HeadsetID,Price,AvailableStoreName,HeadsetName")] VRHeadsetModels vRHeadsetModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vRHeadsetModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vRHeadsetModels);
        }

        // GET: VRHeadsetModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VRHeadsetModels vRHeadsetModels = db.VRHeadsetModels.Find(id);
            if (vRHeadsetModels == null)
            {
                return HttpNotFound();
            }
            return View(vRHeadsetModels);
        }

        // POST: VRHeadsetModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VRHeadsetModels vRHeadsetModels = db.VRHeadsetModels.Find(id);
            db.VRHeadsetModels.Remove(vRHeadsetModels);
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
