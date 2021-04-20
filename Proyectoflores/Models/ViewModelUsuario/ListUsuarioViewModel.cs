using Proyectoflores.Models.ViewModelsFinca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectoflores.Models.ViewModelUsuario
{
    public class ListUsuarioViewModel
    {
        public int cedula { get; set; }
        public string password { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int idrol { get; set; }
        public int idfinca { get; set; }

        public virtual FincaViewModel fincaViewModel { get; set; }
        public virtual rol rol { get; set; }

    }
}