using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Gameflix.Areas.Cyberpunk2077.Models;
using Gameflix.Contexts;

namespace Gameflix.Areas.Cyberpunk2077.Controllers
{
    public class Season1Controller : Controller
    {
        private Cyberpunk2077Context db = new Cyberpunk2077Context();

        // GET: Cyberpunk2077/Season1
        public ActionResult Index()
        {
            return View(db.Season1.OrderBy(s => s.episodeNumber).ToList());
        }

        // GET: Cyberpunk2077/Season1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season1 season1 = db.Season1.Find(id);
            if (season1 == null)
            {
                return HttpNotFound();
            }
            return View(season1);
        }

        // GET: Cyberpunk2077/Season1/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cyberpunk2077/Season1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Season1Id,episodeNumber,Title,Description,Video")] Season1 season1)
        {
            if (ModelState.IsValid)
            {
                db.Season1.Add(season1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(season1);
        }

        // GET: Cyberpunk2077/Season1/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season1 season1 = db.Season1.Find(id);
            if (season1 == null)
            {
                return HttpNotFound();
            }
            return View(season1);
        }

        // POST: Cyberpunk2077/Season1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Season1Id,episodeNumber,Title,Description,Video")] Season1 season1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(season1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(season1);
        }

        // GET: Cyberpunk2077/Season1/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season1 season1 = db.Season1.Find(id);
            if (season1 == null)
            {
                return HttpNotFound();
            }
            return View(season1);
        }

        // POST: Cyberpunk2077/Season1/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Season1 season1 = db.Season1.Find(id);
            db.Season1.Remove(season1);
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
