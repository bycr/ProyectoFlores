using Proyectoflores.Models.ViewModelsFinca;
using Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyectoflores.Models.ViewModelInvernadero
{
    public class InvernaderoViewModel
    {
       
        public int Idinvernadero { get; set; }

        [Required(ErrorMessageResourceType = typeof(Recurso), ErrorMessageResourceName = "Invernadero_errorm_numero")]
        [Display (ResourceType =typeof(Recurso), Name = "Invernadero_numero")]
        public int Numeroinvernadero { get; set; }

        [Display(ResourceType = typeof(Recurso), Name = "Invernadero_finca")]
        public int Idfinca { get; set; }

    }
}