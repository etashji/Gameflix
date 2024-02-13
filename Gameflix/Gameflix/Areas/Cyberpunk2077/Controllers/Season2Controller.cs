using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Gameflix.Areas.Cyberpunk2077.Models;
using Gameflix.Contexts;

namespace Gameflix.Areas.Cyberpunk2077.Controllers
{
    public class Season2Controller : Controller
    {
        private Cyberpunk2077Context db = new Cyberpunk2077Context();

        // GET: Cyberpunk2077/Season2
        public ActionResult Index()
        {
            return View(db.Season2.OrderBy(s =>s.episodeNumber).ToList());
        }

        // GET: Cyberpunk2077/Season2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season2 season2 = db.Season2.Find(id);
            if (season2 == null)
            {
                return HttpNotFound();
            }
            return View(season2);
        }

        // GET: Cyberpunk2077/Season2/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cyberpunk2077/Season2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Season2Id,episodeNumber,Title,Description,Video")] Season2 season2)
        {
            if (ModelState.IsValid)
            {
                db.Season2.Add(season2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(season2);
        }

        // GET: Cyberpunk2077/Season2/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season2 season2 = db.Season2.Find(id);
            if (season2 == null)
            {
                return HttpNotFound();
            }
            return View(season2);
        }

        // POST: Cyberpunk2077/Season2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Season2Id,episodeNumber,Title,Description,Video")] Season2 season2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(season2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(season2);
        }

        // GET: Cyberpunk2077/Season2/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season2 season2 = db.Season2.Find(id);
            if (season2 == null)
            {
                return HttpNotFound();
            }
            return View(season2);
        }

        // POST: Cyberpunk2077/Season2/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Season2 season2 = db.Season2.Find(id);
            db.Season2.Remove(season2);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
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
