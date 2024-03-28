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
    public class HopDongsController : Controller
    {
        private ThueTro db = new ThueTro();

        // GET: HopDongs
        public ActionResult Index()
        {
            var hopDongs = db.HopDongs.Include(h => h.CT_HopDong);
            return View(hopDongs.ToList());
        }

        // GET: HopDongs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.HopDongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // GET: HopDongs/Create
        public ActionResult Create()
        {
            ViewBag.idHopDong = new SelectList(db.CT_HopDong, "IdHopDong", "IdHopDong");
            return View();
        }

        // POST: HopDongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCTHD,idHopDong,TenPhongTro,TongTien")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                db.HopDongs.Add(hopDong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idHopDong = new SelectList(db.CT_HopDong, "IdHopDong", "IdHopDong", hopDong.idHopDong);
            return View(hopDong);
        }

        // GET: HopDongs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.HopDongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            ViewBag.idHopDong = new SelectList(db.CT_HopDong, "IdHopDong", "IdHopDong", hopDong.idHopDong);
            return View(hopDong);
        }

        // POST: HopDongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCTHD,idHopDong,TenPhongTro,TongTien")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hopDong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idHopDong = new SelectList(db.CT_HopDong, "IdHopDong", "IdHopDong", hopDong.idHopDong);
            return View(hopDong);
        }

        // GET: HopDongs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HopDong hopDong = db.HopDongs.Find(id);
            if (hopDong == null)
            {
                return HttpNotFound();
            }
            return View(hopDong);
        }

        // POST: HopDongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HopDong hopDong = db.HopDongs.Find(id);
            db.HopDongs.Remove(hopDong);
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
