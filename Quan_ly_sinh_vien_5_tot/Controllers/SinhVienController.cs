using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Quan_ly_sinh_vien_5_tot.Models;

namespace Quan_ly_sinh_vien_5_tot.Controllers
{
    public class SinhVienController : Controller
    {
        private Quan_ly_sinh_vien_5_totContext db = new Quan_ly_sinh_vien_5_totContext();

        // GET: /SinhVien/
        public ActionResult Index()
        {
            var sinhviens = db.SinhViens.Include(s => s.Lop);
            return View(sinhviens.ToList());
        }

        // GET: /SinhVien/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhvien = db.SinhViens.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            return View(sinhvien);
        }

        // GET: /SinhVien/Create
        public ActionResult Create()
        {
            ViewBag.LopId = new SelectList(db.Lops, "LopId", "LopId");
            return View();
        }

        // POST: /SinhVien/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="SinhVienId,LopId,MSSV,Ho,Ten,NgaySinh")] SinhVien sinhvien)
        {
            if (ModelState.IsValid)
            {
                db.SinhViens.Add(sinhvien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LopId = new SelectList(db.Lops, "LopId", "LopId", sinhvien.LopId);
            return View(sinhvien);
        }

        // GET: /SinhVien/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhvien = db.SinhViens.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.LopId = new SelectList(db.Lops, "LopId", "LopId", sinhvien.LopId);
            return View(sinhvien);
        }

        // POST: /SinhVien/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="SinhVienId,LopId,MSSV,Ho,Ten,NgaySinh")] SinhVien sinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LopId = new SelectList(db.Lops, "LopId", "LopId", sinhvien.LopId);
            return View(sinhvien);
        }

        // GET: /SinhVien/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhvien = db.SinhViens.Find(id);
            if (sinhvien == null)
            {
                return HttpNotFound();
            }
            return View(sinhvien);
        }

        // POST: /SinhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SinhVien sinhvien = db.SinhViens.Find(id);
            db.SinhViens.Remove(sinhvien);
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
