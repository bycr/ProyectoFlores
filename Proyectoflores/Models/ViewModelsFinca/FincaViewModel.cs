using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyectoflores.Models.ViewModelsFinca
{
    public class FincaViewModel
    {
        public int Idfinca { get; set; }
        [Required]
        [DisplayName("Nombre de la finca")]
        public string Nombrefinca { get; set; }
        [Required]
        [DisplayName("Ubicación")]
        public string Ubicacion { get; set; }
    }
}