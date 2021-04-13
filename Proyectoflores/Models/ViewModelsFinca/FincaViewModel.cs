using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyectoflores.Models.ViewModelsFinca
{
    public class FincaViewModel
    {
        public int Idfinca { get; set; }
        [Required]
        public string Nombrefinca { get; set; }
        [Required]
        public string Ubicacion { get; set; }
    }
}