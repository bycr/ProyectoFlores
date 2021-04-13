﻿using Proyectoflores.Models.ViewModelInvernadero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyectoflores.Models;
using Proyectoflores.Models.ViewModelsFinca;

namespace Proyectoflores.Controllers
{
    public class InvernaderoController : Controller
    {
        // GET: Invernadero
        public ActionResult ListaInvernadero()
        {
            List<ListInvernaderoViewModel> lst;

            using(proyectofloresEntities db = new proyectofloresEntities())
            {
                lst = (from d in db.invernadero
                       select new ListInvernaderoViewModel
                       {
                           Idinvernadero = d.idinvernadero,
                           Numeroinvernadero = d.numeroinvernadero,
                           Idfinca = d.idfinca

                       }).ToList();
            }

            return View(lst);
        }

        public ActionResult NuevoInvernadero()
        {
            Models.invernadero mod = new Models.invernadero();
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                
                mod.FincaCollection = db.finca.ToList<finca>();
            }
            return View(mod);
        }

        [HttpPost]
        public ActionResult NuevoInvernadero(Models.invernadero model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    using (proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oInvernadero = new Models.invernadero();

                        oInvernadero.numeroinvernadero = model.numeroinvernadero;
                        oInvernadero.idfinca = model.idfinca;


                        db.invernadero.Add(oInvernadero);
                        db.SaveChanges();

                    }

                    return Redirect("~/Invernadero/ListaInvernadero");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //editar invernaderos
        public ActionResult EditarInvernadero(int Id)
        {
            invernadero mod = new invernadero();
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oInvernadero = db.invernadero.Find(Id);
                mod.numeroinvernadero = oInvernadero.numeroinvernadero;
                //mod.idfinca = oInvernadero.idfinca;
                mod.FincaCollection = db.finca.ToList<finca>();
            }
            return View(mod);
        }

        [HttpPost]
        public ActionResult EditarInvernadero(invernadero model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oInvernadero = db.invernadero.Find(model.idinvernadero);

                        oInvernadero.numeroinvernadero = model.numeroinvernadero;
                        oInvernadero.idfinca = model.idfinca;

                        db.Entry(oInvernadero).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/Invernadero/ListaInvernadero");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Eliminar 
        [HttpGet]
        public ActionResult EliminarInvernadero(int Id)
        {
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oInvernadero = db.invernadero.Find(Id);
                db.invernadero.Remove(oInvernadero);
                db.SaveChanges();
            }
            return Redirect("~/Invernadero/ListaInvernadero");
        }
    }
}