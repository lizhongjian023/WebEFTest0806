using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;

namespace WebEFTest0806.Controllers
{
    public class UserMSGsController : Controller
    {
        private HT_NewsEntities db = new HT_NewsEntities();

        // GET: UserMSGs
        public ActionResult Index()
        {
            return View(db.UserMSG.ToList());
        }

        // GET: UserMSGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMSG userMSG = db.UserMSG.Find(id);
            if (userMSG == null)
            {
                return HttpNotFound();
            }
            return View(userMSG);
        }

        // GET: UserMSGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserMSGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userid,password,zt,username,workcode,Email,phoneNumber,address,departmentid,company,login")] UserMSG userMSG)
        {
            if (ModelState.IsValid)
            {
                db.UserMSG.Add(userMSG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userMSG);
        }

        // GET: UserMSGs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMSG userMSG = db.UserMSG.Find(id);
            if (userMSG == null)
            {
                return HttpNotFound();
            }
            return View(userMSG);
        }

        // POST: UserMSGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userid,password,zt,username,workcode,Email,phoneNumber,address,departmentid,company,login")] UserMSG userMSG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userMSG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userMSG);
        }

        // GET: UserMSGs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserMSG userMSG = db.UserMSG.Find(id);
            if (userMSG == null)
            {
                return HttpNotFound();
            }
            return View(userMSG);
        }

        // POST: UserMSGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserMSG userMSG = db.UserMSG.Find(id);
            db.UserMSG.Remove(userMSG);
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
