using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS.Areas.Admin.Controllers
{
    public class ReportingPersopnController : Controller
    {
        // GET: Admin/ReportingPersopn
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/ReportingPersopn/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/ReportingPersopn/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ReportingPersopn/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ReportingPersopn/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/ReportingPersopn/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ReportingPersopn/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/ReportingPersopn/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
