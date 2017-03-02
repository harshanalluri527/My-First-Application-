using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Applabs.Marketing.Demo.Models;

namespace Applabs.Marketing.Demo.Controllers
{
    public class C_Marketing_ListController : Controller
    {
        private HarshaEntities db = new HarshaEntities();

        // GET: C_Marketing_List
        public ActionResult Index()
        {
            return View(db.C_Marketing_List.ToList());
        }

        // GET: C_Marketing_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Marketing_List c_Marketing_List = db.C_Marketing_List.Find(id);
            if (c_Marketing_List == null)
            {
                return HttpNotFound();
            }
            return View(c_Marketing_List);
        }

        // GET: C_Marketing_List/Create
        public ActionResult Create()
        {
            C_Marketing_List Mar = new C_Marketing_List();
           Mar.emp = db.Employees.Where(x => x.Is_Internal_Employee == false).ToList();
            Mar.mar = db.Employees.Where(x => x.Is_Internal_Employee == true).ToList();
            return View(Mar);
        }

        // POST: C_Marketing_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save([Bind(Include = "Marketing_ID,Employee_Name,Marketer_Name,Marketing_Start_Date,Case_Status,Marketing_End_Date,Current_Status")] C_Marketing_List c_Marketing_List)
        {
            if (ModelState.IsValid)
            {
                db.C_Marketing_List.Add(c_Marketing_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c_Marketing_List);
        }

        // GET: C_Marketing_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Marketing_List c_Marketing_List = db.C_Marketing_List.Find(id);
            if (c_Marketing_List == null)
            {
                return HttpNotFound();
            }
            return View(c_Marketing_List);
        }

        // POST: C_Marketing_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Marketing_ID,Employee_Name,Marketer_Name,Marketing_Start_Date,Case_Status,Marketing_End_Date,Current_Status")] C_Marketing_List c_Marketing_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_Marketing_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c_Marketing_List);
        }

        // GET: C_Marketing_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_Marketing_List c_Marketing_List = db.C_Marketing_List.Find(id);
            if (c_Marketing_List == null)
            {
                return HttpNotFound();
            }
            return View(c_Marketing_List);
        }

        // POST: C_Marketing_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            C_Marketing_List c_Marketing_List = db.C_Marketing_List.Find(id);
            db.C_Marketing_List.Remove(c_Marketing_List);
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
