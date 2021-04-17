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
        [StringLength(50)]
        [Display(Name = "Nombre de la finca")]
        public string Nombrefinca { get; set; }
        [Required]
        [Display(Name = "Ubicación")]
        [StringLength(50)]
        public string Ubicacion { get; set; }
    }
}