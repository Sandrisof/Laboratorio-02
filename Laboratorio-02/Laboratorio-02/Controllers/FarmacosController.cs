using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_02.Controllers
{
    public class FarmacosController : Controller
    {
        // GET: Farmacos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Farmacos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Farmacos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Farmacos/Create
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

        // GET: Farmacos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Farmacos/Edit/5
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

        // GET: Farmacos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Farmacos/Delete/5
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
