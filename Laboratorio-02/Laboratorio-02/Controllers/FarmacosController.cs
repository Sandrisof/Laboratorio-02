using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Laboratorio_02.Models;

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

        [HttpPost]
        public ActionResult CargarArchivo(HttpPostedFileBase archivo)
        {
            try
            {
                FarmacosModel Farmacos = new FarmacosModel();
                StreamReader Reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "/Prueba/" + archivo.FileName);
                int Iteracion = 0;
                string Dato;
                while (Reader.Peek() >= 0)
                {
                    string LeerLinea = Reader.ReadLine();
                    Dato = "";
                    for (int i = 0; i < LeerLinea.Length; i++)
                    {
                        if (LeerLinea.Substring(i,1) != ",")
                        {
                            Dato = Dato + LeerLinea.Substring(i, 1);
                        }
                        else
                        {
                            if (Iteracion == 0)
                            {
                                if (Dato != "id")
                                {
                                    Farmacos.Id = int.Parse(Dato);
                                }
                                Iteracion++;
                                Dato = "";
                            }
                            else if (Iteracion == 1)
                            {
                                if (Dato != "nombre")
                                {
                                    Farmacos.Nombre = Dato;
                                }
                                Iteracion++;
                                Dato = "";
                            }
                            else if (Iteracion == 2)
                            {
                                if (Dato != "descripcion")
                                {
                                    Farmacos.Descripcion = Dato;
                                }
                                Iteracion++;
                                Dato = "";
                            }
                            else if (Iteracion == 3)
                            {
                                if (Dato != "casa_productora")
                                {
                                    Farmacos.CasaProductora = Dato;
                                }
                                Iteracion++;
                                Dato = "";
                            }
                            else if (Iteracion == 4)
                            {
                                if (Dato != "precio")
                                {
                                    Farmacos.Precio = double.Parse(Dato);
                                }
                                Iteracion++;
                                Dato = "";
                            }
                            else if (Iteracion == 5)
                            {
                                if (Dato != "existecia")
                                {
                                    Farmacos.Existencia = int.Parse(Dato);
                                }
                                Iteracion++;
                                Dato = "";
                            }
                        }
                    }
                    Iteracion = 0;
                }
                Reader.Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
               
            }
        }
    }
}
