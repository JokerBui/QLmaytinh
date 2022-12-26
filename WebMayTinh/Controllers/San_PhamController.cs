using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMayTinh.Models.Entity;

namespace WebMayTinh.Controllers
{
    public class San_PhamController : Controller
    {
        private Model1 db = new Model1();

        // GET: San_Pham
        public ActionResult Index()
        {
            var san_Pham = db.San_Pham.Include(s => s.Thuong_Hieu);
            return View(san_Pham.ToList());
        }

        // GET: San_Pham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_Pham san_Pham = db.San_Pham.Find(id);
            if (san_Pham == null)
            {
                return HttpNotFound();
            }
            return View(san_Pham);
        }

        // GET: San_Pham/Create
        public ActionResult Create()
        {
            ViewBag.MaThuongHieu = new SelectList(db.Thuong_Hieu, "MaThuongHieu", "Ten");
            return View();
        }

        // POST: San_Pham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( San_Pham san_Pham)
        {
            if (san_Pham.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(san_Pham.ImageUpload.FileName);
                string extension = Path.GetExtension(san_Pham.ImageUpload.FileName);
                fileName = fileName + extension;
                san_Pham.Anh = "/Content/image/" + fileName;
                san_Pham.ImageUpload.SaveAs(Server.MapPath("/Content/image/") + fileName);
            }
            db.San_Pham.Add(san_Pham);
            db.SaveChanges();
            ViewBag.MaThuongHieu = new SelectList(db.Thuong_Hieu, "MaThuongHieu", "Ten", san_Pham.MaThuongHieu);
            return View(san_Pham);
        }

        // GET: San_Pham/Edit/5
        public ActionResult Edit(int? id)
        {
            
            ViewBag.MaThuongHieu = new SelectList(db.Thuong_Hieu, "MaThuongHieu", "Ten");
            return View(db.San_Pham.Where(s => s.MaSanPham == id).FirstOrDefault());
        }

        // POST: San_Pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( San_Pham san_Pham)
        {
            if (ModelState.IsValid)
            {
                if (san_Pham.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(san_Pham.ImageUpload.FileName);
                    string extension = Path.GetExtension(san_Pham.ImageUpload.FileName);
                    fileName = fileName + extension;
                    san_Pham.Anh = "/Content/image/" + fileName;
                    san_Pham.ImageUpload.SaveAs(Server.MapPath("/Content/image/") + fileName);
                }
                db.Entry(san_Pham).State = EntityState.Modified;
                db.SaveChanges();
                return View(san_Pham);
            }
            ViewBag.MaThuongHieu = new SelectList(db.Thuong_Hieu, "MaThuongHieu", "Ten");
            return View(san_Pham);
        }

        // GET: San_Pham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            San_Pham san_Pham = db.San_Pham.Find(id);
            if (san_Pham == null)
            {
                return HttpNotFound();
            }
            return View(san_Pham);
        }

        // POST: San_Pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            San_Pham san_Pham = db.San_Pham.Find(id);
            db.San_Pham.Remove(san_Pham);
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
