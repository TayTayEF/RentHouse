using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThueTro_DACS.Models;

namespace ThueTro_DACS.Controllers
{
    public class PhongTroesController : Controller
    {
        private ThueTro db = new ThueTro();

        // GET: PhongTroes
        public ActionResult Index()
        {
            return View(db.PhongTroes.ToList());
        }

        // GET: PhongTroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongTro phongTro = db.PhongTroes.Find(id);
            if (phongTro == null)
            {
                return HttpNotFound();
            }
            return View(phongTro);
        }

        // GET: PhongTroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhongTroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdPhongTro,Title,GiaCoc,GiaThue,DiaChi,UrlHinhAnh,IdChuTro,MoTa,SDT,DienTich")] PhongTro phongTro)
        {
            if (ModelState.IsValid)
            {
                db.PhongTroes.Add(phongTro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(phongTro);
        }

        // GET: PhongTroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongTro phongTro = db.PhongTroes.Find(id);
            if (phongTro == null)
            {
                return HttpNotFound();
            }
            return View(phongTro);
        }

        // POST: PhongTroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPhongTro,Title,GiaCoc,GiaThue,DiaChi,UrlHinhAnh,IdChuTro,MoTa,SDT,DienTich")] PhongTro phongTro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phongTro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phongTro);
        }

        // GET: PhongTroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhongTro phongTro = db.PhongTroes.Find(id);
            if (phongTro == null)
            {
                return HttpNotFound();
            }
            return View(phongTro);
        }

        // POST: PhongTroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhongTro phongTro = db.PhongTroes.Find(id);
            db.PhongTroes.Remove(phongTro);
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
