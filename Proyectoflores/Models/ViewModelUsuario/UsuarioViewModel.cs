using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyectoflores.Models.ViewModelsFinca;

namespace Proyectoflores.Models.ViewModelUsuario
{
    public class UsuarioViewModel
    {
        public int cedula { get; set; }
        public string password { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int idrol { get; set; }
        public int idfinca { get; set; }

        public virtual FincaViewModel fincaViewModel { get; set; }
        public virtual rol rol { get; set; }

        public List<FincaViewModel> fincaViewModelCollection { get; set; }
        public List<rol> rolCollection { get; set; }

    }
}