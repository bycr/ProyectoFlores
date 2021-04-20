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
                           cedula = d.cedula,
                           //password = d.password,
                           nombres = d.nombres,
                           apellidos = d.apellidos,
                           idrol = d.idrol,
                           idfinca = d.idfinca
                       }).ToList();
            }

            return View(lst);
        }

        public ActionResult NuevoUsuario()
        {
            return View();
        }

        public ActionResult EditarUsuario(int Id)
        {
            return View();
        }

    }
}