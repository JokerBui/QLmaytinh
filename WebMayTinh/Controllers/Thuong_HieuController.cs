using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMayTinh.Models.Entity;

namespace WebMayTinh.Controllers
{
    public class Thuong_HieuController : Controller
    {
        private Model1 db = new Model1();

        // GET: Thuong_Hieu
        public ActionResult Index()
        {
            return View(db.Thuong_Hieu.ToList());
        }

        // GET: Thuong_Hieu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thuong_Hieu thuong_Hieu = db.Thuong_Hieu.Find(id);
            if (thuong_Hieu == null)
            {
                return HttpNotFound();
            }
            return View(thuong_Hieu);
        }

        // GET: Thuong_Hieu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thuong_Hieu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaThuongHieu,Ten")] Thuong_Hieu thuong_Hieu)
        {
            if (ModelState.IsValid)
            {
                db.Thuong_Hieu.Add(thuong_Hieu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thuong_Hieu);
        }

        // GET: Thuong_Hieu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thuong_Hieu thuong_Hieu = db.Thuong_Hieu.Find(id);
            if (thuong_Hieu == null)
            {
                return HttpNotFound();
            }
            return View(thuong_Hieu);
        }

        // POST: Thuong_Hieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaThuongHieu,Ten")] Thuong_Hieu thuong_Hieu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thuong_Hieu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thuong_Hieu);
        }

        // GET: Thuong_Hieu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thuong_Hieu thuong_Hieu = db.Thuong_Hieu.Find(id);
            if (thuong_Hieu == null)
            {
                return HttpNotFound();
            }
            return View(thuong_Hieu);
        }

        // POST: Thuong_Hieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thuong_Hieu thuong_Hieu = db.Thuong_Hieu.Find(id);
            db.Thuong_Hieu.Remove(thuong_Hieu);
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
