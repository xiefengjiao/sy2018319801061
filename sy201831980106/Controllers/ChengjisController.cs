using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sy201831980106.Models;

namespace sy201831980106.Controllers
{
    public class ChengjisController : Controller
    {
        private MyDb db = new MyDb();

        // GET: Chengjis
        public ActionResult Index()
        {
            return View(db.Chengjis.ToList());
        }

        // GET: Chengjis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chengji chengji = db.Chengjis.Find(id);
            if (chengji == null)
            {
                return HttpNotFound();
            }
            return View(chengji);
        }

        // GET: Chengjis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chengjis/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Xuhao,Xueshengxuehao,Xueshengxingming,Xueshengxingbie,Kechengmingcheng,Kechengchengji")] Chengji chengji)
        {
            if (ModelState.IsValid)
            {
                db.Chengjis.Add(chengji);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chengji);
        }

        // GET: Chengjis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chengji chengji = db.Chengjis.Find(id);
            if (chengji == null)
            {
                return HttpNotFound();
            }
            return View(chengji);
        }

        // POST: Chengjis/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Xuhao,Xueshengxuehao,Xueshengxingming,Xueshengxingbie,Kechengmingcheng,Kechengchengji")] Chengji chengji)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chengji).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chengji);
        }

        // GET: Chengjis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chengji chengji = db.Chengjis.Find(id);
            if (chengji == null)
            {
                return HttpNotFound();
            }
            return View(chengji);
        }

        // POST: Chengjis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Chengji chengji = db.Chengjis.Find(id);
            db.Chengjis.Remove(chengji);
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
