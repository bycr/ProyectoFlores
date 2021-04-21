using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyectoflores.Models;
using Proyectoflores.Models.ViewModelUsuario;

namespace Proyectoflores.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult ListaUsuario()
        {
            List<ListUsuarioViewModel> lst;
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                lst = (from d in db.usuario
                       select new ListUsuarioViewModel
                       {
                           Cedula = d.cedula,
                           //password = d.password,
                           Nombres = d.nombres,
                           Apellidos = d.apellidos,
                           Idrol = d.idrol,
                           Idfinca = d.idfinca
                       }).ToList();
            }

            return View(lst);
        }

        public ActionResult NuevoUsuario(int id = 0)
        {
            usuario mod = new usuario();
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                if(id != 0)
                    mod = db.usuario.Where(x => x.idfinca == id).FirstOrDefault();
                    mod.fincaCollection = db.finca.ToList<finca>();
                    mod.rolCollection = db.rol.ToList<rol>();
            }

            return View(mod);
        }

        [HttpPost]
        public ActionResult NuevoUsuario(usuario model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oUsuario = new usuario();

                        oUsuario.cedula = model.cedula;
                        oUsuario.password = model.password;
                        oUsuario.nombres = model.nombres;
                        oUsuario.apellidos = model.apellidos;
                        oUsuario.idrol = model.idrol;
                        oUsuario.idfinca = model.idfinca;

                        db.usuario.Add(oUsuario);
                        db.SaveChanges();

                    }

                    return Redirect("~/Usuario/ListaUsuario");
                }
                return View(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult EditarUsuario(int Id, int id)
        {
            usuario mod = new usuario();
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oUsuario = db.usuario.Find(Id);
                mod.password = oUsuario.password;
                mod.nombres = oUsuario.nombres;
                mod.apellidos = oUsuario.apellidos;
                //mod.idrol = oUsuario.idrol;
                //mod.idfinca = oUsuario.idfinca;
                //mod.cedula = oUsuario.cedula;

                if (id != 0)
                    mod = db.usuario.Where(x => x.idfinca == id).FirstOrDefault();
                    mod.fincaCollection = db.finca.ToList<finca>();
                    mod = db.usuario.Where(x => x.idrol == id).FirstOrDefault();
                    mod.rolCollection = db.rol.ToList<rol>();
            }

            return View(mod);
        }

        [HttpPost]
        public ActionResult EditarUsuario(usuario model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (proyectofloresEntities db = new proyectofloresEntities())
                    {
                        var oUsuario = db.usuario.Find(model.cedula);

                        //oUsuario.cedula = model.cedula;
                        oUsuario.password = model.password;
                        oUsuario.nombres = model.nombres;
                        oUsuario.apellidos = model.apellidos;
                        oUsuario.idrol = model.idrol;
                        oUsuario.idfinca = model.idfinca;

                        db.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }

                    return Redirect("~/Usuario/ListaUsuario");
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
        public ActionResult EliminarUsuario(int Id)
        {
            using (proyectofloresEntities db = new proyectofloresEntities())
            {
                var oUsuario = db.usuario.Find(Id);
                db.usuario.Remove(oUsuario);
                db.SaveChanges();
            }
            return Redirect("~/Usuario/ListaUsuario");
        }

    }
}