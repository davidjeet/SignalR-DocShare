using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;
using WebUI.Membership;

namespace WebUI.Controllers
{ 
    public class DocController : Controller
    {
        private DocShareContext db = new DocShareContext();

        //
        // GET: /Doc/

        public ViewResult Index()
        {
            return View(db.Documents.ToList());
        }

        //
        // GET: /Doc/Details/5

        public ViewResult Details(int id)
        {
            Document document = db.Documents.Find(id);
            return View(document);
        }

        //
        // GET: /Doc/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Doc/Create

        [HttpPost]
        public ActionResult Create(Document document)
        {
            if (ModelState.IsValid)
            {
                db.Documents.Add(document);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(document);
        }
        
        //
        // GET: /Doc/Edit/5
 
        public ActionResult Edit(int id)
        {
            Document document = db.Documents.Find(id);
            return View(document);
        }

        //
        // POST: /Doc/Edit/5

        [HttpPost]
        public ActionResult Edit(Document document)
        {
            if (ModelState.IsValid)
            {
                db.Entry(document).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(document);
        }


        //
        // GET: /Doc/Edit/5

        public ActionResult Review(int id)
        {
            Document document = db.Documents.Find(id);
            return View(document);
        }

        //
        // POST: /Doc/Edit/5

        [HttpPost]
        public ActionResult Review(Document document)
        {
            if (ModelState.IsValid)
            {
                db.Entry(document).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(document);
        }






        //
        // GET: /Doc/Delete/5
 
        public ActionResult Delete(int id)
        {
            Document document = db.Documents.Find(id);
            return View(document);
        }

        //
        // POST: /Doc/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Document document = db.Documents.Find(id);
            db.Documents.Remove(document);
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