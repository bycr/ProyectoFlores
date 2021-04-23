using Proyectoflores.Filters;
using Proyectoflores.Models;
using Proyectoflores.Models.ViewModelsFinca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectoflores.Controllers
{
    public class FincaController : Controller
    {
        // GET: finca
        public static string vistalista() {
            return "lst";
        }

        [AuthorizeUser(idOperacion:1)]
        public ActionResult ListaFinca()
        {
            List<ListFincaViewModel>  lst;

            using (proyectofloresEntities db = new proyectofloresEntities() )
            {
                lst = (from d in db.finca
                       select new ListFincaViewModel
                       {
                           Idfinca = d.idfinca,
                           Nombrefinca = d.nombrefinca,
                           Ubicacion = d.ubicacionf

                       }).ToList();
            }

            return View(lst);
        }

        [AuthorizeUser(idOperacion:2)]
        public ActionResult NuevaFinca()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NuevaFinca(FincaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oFinca = new finca();

                        oFinca.nombrefinca = model.Nombrefinca;
                        oFinca.ubicacionf = model.Ubicacion;                 

                        db.finca.Add(oFinca);
                        db.SaveChanges();

                    }
                                
                    return Redirect("~/finca/ListaFinca");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //editar finca
        [AuthorizeUser(idOperacion:5)]
        public ActionResult EditarFinca(int Id)
        {
            FincaViewModel model = new FincaViewModel();
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oFinca = db.finca.Find(Id);
                model.Nombrefinca = oFinca.nombrefinca;
                model.Ubicacion = oFinca.ubicacionf;
                model.Idfinca = oFinca.idfinca;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarFinca(FincaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oFinca = db.finca.Find(model.Idfinca);
                        oFinca.nombrefinca = model.Nombrefinca;
                        oFinca.ubicacionf = model.Ubicacion;

                        db.Entry(oFinca).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/finca/ListaFinca");
                }
                return View(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [AuthorizeUser(idOperacion:6)]
        [HttpGet]
        public ActionResult EliminarFinca(int Id)
        {
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oFinca = db.finca.Find(Id);
                db.finca.Remove(oFinca);
                db.SaveChanges();
            }
            return Redirect("~/finca/ListaFinca");
        }
    }
}