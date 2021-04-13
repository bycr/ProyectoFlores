using Proyectoflores.Models.ViewModelsFinca;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyectoflores.Models.ViewModelInvernadero
{
    public class InvernaderoViewModel
    {
        public int Idinvernadero { get; set; }
        public int Numeroinvernadero { get; set; }
        public int Idfinca { get; set; }

        [NotMapped]
        public List<ListFincaViewModel> ListFincaViewModelCollection { get; set; }
    }
}