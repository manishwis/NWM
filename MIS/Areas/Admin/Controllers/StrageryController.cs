using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS.Areas.Admin.Controllers
{
    public class StrageryController : Controller
    {
        // GET: Admin/Stragery
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Stragery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Stragery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Stragery/Create
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

        // GET: Admin/Stragery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Stragery/Edit/5
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

        // GET: Admin/Stragery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Stragery/Delete/5
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
