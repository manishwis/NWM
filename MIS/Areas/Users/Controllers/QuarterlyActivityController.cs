using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS.Areas.Users.Controllers
{
    public class QuarterlyActivityController : Controller
    {
        // GET: Users/QuarterlyActivity
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/QuarterlyActivity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/QuarterlyActivity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/QuarterlyActivity/Create
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

        // GET: Users/QuarterlyActivity/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/QuarterlyActivity/Edit/5
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

        // GET: Users/QuarterlyActivity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/QuarterlyActivity/Delete/5
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
