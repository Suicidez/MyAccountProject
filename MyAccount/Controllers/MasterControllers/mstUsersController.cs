using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyAccount.Models;
using MyAccount.Models.MasterModels;

namespace MyAccount.Controllers.MasterControllers
{
    public class mstUsersController : Controller
    {
        private MyAccountContext db = new MyAccountContext();

        // GET: mstUsers
        public ActionResult Index()
        {
            return View(db.mstUser.ToList());
        }

        // GET: mstUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            mstUser mstUser = db.mstUser.FirstOrDefault();
            if (mstUser == null)
            {
                return HttpNotFound();
            }
            return View(mstUser);
        }

        // GET: mstUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mstUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RunningId,UserId,Password,FirstName,LastName,CompanyName,IsPermission,isCompany,isActive,LoginTimes,isLock,isTrial,StartTrial,EndTrial,CreateUser,CreateDate,UpdateUser,UpdateTime")] mstUser mstUser)
        {
            if (ModelState.IsValid)
            {
                db.mstUser.Add(mstUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mstUser);
        }

        // GET: mstUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mstUser mstUser = db.mstUser.Find(id);
            if (mstUser == null)
            {
                return HttpNotFound();
            }
            return View(mstUser);
        }

        // POST: mstUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RunningId,UserId,Password,FirstName,LastName,CompanyName,IsPermission,isCompany,isActive,LoginTimes,isLock,isTrial,StartTrial,EndTrial,CreateUser,CreateDate,UpdateUser,UpdateTime")] mstUser mstUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mstUser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mstUser);
        }

        // GET: mstUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            mstUser mstUser = db.mstUser.Find(id);
            if (mstUser == null)
            {
                return HttpNotFound();
            }
            return View(mstUser);
        }

        // POST: mstUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mstUser mstUser = db.mstUser.Find(id);
            db.mstUser.Remove(mstUser);
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
