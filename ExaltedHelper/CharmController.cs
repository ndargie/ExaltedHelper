using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExaltedHelper.Models;
using ExaltedHelper.DAL;

namespace ExaltedHelper
{
    public class CharmController : Controller
    {
        private CharmContext _db;

        public CharmController()
        {
            _db = new CharmContext();
            _db.Database.Initialize(true);
        }

        // GET: /Charm/
        public ActionResult Index()
        {
            var charmmodel = _db.CharmModel.Include(m => m.ExaltedType);
            return View(charmmodel.ToList());
        }

        // GET: /Charm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharmDataModel charmdatamodel = _db.CharmModel.Find(id);
            if (charmdatamodel == null)
            {
                return HttpNotFound();
            }
            return View(charmdatamodel);
        }

        // GET: /Charm/Create
        public ActionResult Create()
        {
            ViewBag.ExaltedTypeDataModelId = new SelectList(_db.ExaltedTypeModel, "Id", "Description");
            return View();
        }

        // POST: /Charm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Description,ExaltedTypeDataModelId,MinimumEssance,MinimumAbility,WillPowerCost,EssanceCost,HealthCost")] CharmDataModel charmdatamodel)
        {
            if (ModelState.IsValid)
            {
                _db.CharmModel.Add(charmdatamodel);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExaltedTypeDataModelId = new SelectList(_db.ExaltedTypeModel, "Id", "Description", charmdatamodel.ExaltedTypeDataModelId);
            return View(charmdatamodel);
        }

        // GET: /Charm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharmDataModel charmdatamodel = _db.CharmModel.Find(id);
            if (charmdatamodel == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExaltedTypeDataModelId = new SelectList(_db.ExaltedTypeModel, "Id", "Description", charmdatamodel.ExaltedTypeDataModelId);
            return View(charmdatamodel);
        }

        // POST: /Charm/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Description,ExaltedTypeDataModelId,MinimumEssance,MinimumAbility,WillPowerCost,EssanceCost,HealthCost")] CharmDataModel charmdatamodel)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(charmdatamodel).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExaltedTypeDataModelId = new SelectList(_db.ExaltedTypeModel, "Id", "Description", charmdatamodel.ExaltedTypeDataModelId);
            return View(charmdatamodel);
        }

        // GET: /Charm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CharmDataModel charmdatamodel = _db.CharmModel.Find(id);
            if (charmdatamodel == null)
            {
                return HttpNotFound();
            }
            return View(charmdatamodel);
        }

        // POST: /Charm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CharmDataModel charmdatamodel = _db.CharmModel.Find(id);
            _db.CharmModel.Remove(charmdatamodel);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
