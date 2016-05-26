using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EducationDepartmentV1.Models;

namespace EducationDepartmentV1.Controllers
{
    public class flowChartsController : Controller
    {
        private FlowchartDBContext db = new FlowchartDBContext();

        // GET: flowCharts
        public ActionResult Index()
        {
            return View(db.flowCharts.ToList());
        }

        // GET: flowCharts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flowChart flowChart = db.flowCharts.Find(id);
            if (flowChart == null)
            {
                return HttpNotFound();
            }
            return View(flowChart);
        }

        // GET: flowCharts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: flowCharts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,jsonDoc")] flowChart flowChart)
        {
            if (ModelState.IsValid)
            {
                db.flowCharts.Add(flowChart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flowChart);
        }

        // GET: flowCharts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flowChart flowChart = db.flowCharts.Find(id);
            if (flowChart == null)
            {
                return HttpNotFound();
            }
            return View(flowChart);
        }

        // POST: flowCharts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,jsonDoc")] flowChart flowChart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flowChart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flowChart);
        }

        // GET: flowCharts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            flowChart flowChart = db.flowCharts.Find(id);
            if (flowChart == null)
            {
                return HttpNotFound();
            }
            return View(flowChart);
        }

        // POST: flowCharts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            flowChart flowChart = db.flowCharts.Find(id);
            db.flowCharts.Remove(flowChart);
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
