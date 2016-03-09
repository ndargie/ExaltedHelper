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
using AutoMapper;

namespace ExaltedHelper
{
    public class CharmController : Controller
    {
        private CharmContext _db;

        public CharmController()
        {
            _db = new CharmContext();
        }

        public ActionResult Index()
        {
            ViewBag.ExaltedTypes = new SelectList(_db.ExaltedTypeModel.ToList(), "Id", "Description");
            var charmModel = from m in _db.CharmModel.Include(e => e.ExaltedType)
                             orderby m.Name
                             select m;
            return View(Mapper.Map<CharmDataModel[], CharmEditViewModel[]>(charmModel.ToArray()).ToList());
        }

        public ActionResult FilterAction(int exaltedTypeId)
        {
            ExaltedTypeDataModel exaltedType = _db.ExaltedTypeModel.Single(x => x.Id == exaltedTypeId);
           var charmModel = from m in _db.CharmModel.Include(e => e.ExaltedType)
                             orderby m.Name
                             where m.ExaltedType.Description == exaltedType.Description
                             select m;
           return PartialView("_Charms", Mapper.Map<CharmDataModel[], CharmEditViewModel[]>(charmModel.ToArray()).ToList());
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
            CharmViewModel view = new CharmViewModel();
            view.ExaltedTypes = _db.ExaltedTypeModel.ToList().Select(Mapper.Map<ExaltedTypeViewModel>).ToList();
            return View(view);
        }

        // POST: /Charm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CharmViewModel charmViewModel)
        {
            CharmDataModel charm = Mapper.Map<CharmDataModel>(charmViewModel);
            if (ModelState.IsValid)
            {
                _db.CharmModel.Add(charm);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            charmViewModel.ExaltedTypes = _db.ExaltedTypeModel.ToList().Select(Mapper.Map<ExaltedTypeViewModel>).ToList();
            return View(charmViewModel);
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
        public ActionResult Edit([Bind(Include = "Id,Name,Description,ExaltedTypeDataModelId,MinimumEssance,MinimumAbility,WillPowerCost,EssanceCost,HealthCost")] CharmDataModel charmdatamodel)
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

        public ActionResult FilterResults(string exaltedtype)
        {
            List<CharmDataModel> charmDM = _db.CharmModel.Include(m => m.ExaltedType).Where(x => x.ExaltedType.Description == exaltedtype).ToList();
            List<CharmViewModel> charms = Mapper.Map<CharmDataModel[], CharmViewModel[]>(charmDM.ToArray()).ToList();
            return PartialView(charms);
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
