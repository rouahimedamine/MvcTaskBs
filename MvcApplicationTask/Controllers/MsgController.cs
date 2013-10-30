using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationTask.Models;

namespace MvcApplicationTask.Controllers
{
    public class MsgController : Controller
    {
        private MsgContext db = new MsgContext();

        //
        // GET: /Msg/

        public ActionResult Index()
        {
            return View(db.MsgModels.ToList());
        }

        //
        // GET: /Msg/Details/5

        public ActionResult Details(int id = 0)
        {
            MsgModels msgmodels = db.MsgModels.Find(id);
            if (msgmodels == null)
            {
                return HttpNotFound();
            }
            return View(msgmodels);
        }

        //
        // GET: /Msg/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Msg/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MsgModels msgmodels)
        {
            if (ModelState.IsValid)
            {
                db.MsgModels.Add(msgmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(msgmodels);
        }

        //
        // GET: /Msg/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MsgModels msgmodels = db.MsgModels.Find(id);
            if (msgmodels == null)
            {
                return HttpNotFound();
            }
            return View(msgmodels);
        }

        //
        // POST: /Msg/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MsgModels msgmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(msgmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(msgmodels);
        }

        //
        // GET: /Msg/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MsgModels msgmodels = db.MsgModels.Find(id);
            if (msgmodels == null)
            {
                return HttpNotFound();
            }
            return View(msgmodels);
        }

        //
        // POST: /Msg/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MsgModels msgmodels = db.MsgModels.Find(id);
            db.MsgModels.Remove(msgmodels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}