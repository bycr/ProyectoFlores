using Proyectoflores.Models.ViewModelsFinca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectoflores.Models.ViewModelUsuario
{
    public class ListUsuarioViewModel
    {
        public int Cedula { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Idrol { get; set; }
        public int Idfinca { get; set; }

        public virtual FincaViewModel fincaViewModel { get; set; }
        public virtual rol rol { get; set; }

    }
}