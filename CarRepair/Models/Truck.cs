using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRepair.Models
{
    public class Truck : Car
    {
        [Display(Name = "Состояние гидравлической системы:")]
        [Range(0, 100)]
        public int Hydraulic { get; set; }
    }
}