using CarRepair.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRepair.Models
{
    public class Bus : Car
    {
        [Display(Name = "Состояние поручней:")]
        [Range(0, 100)]
        public int GrabHandle { get; set; }

        [ServiceCost(300)]
        [Display(Name = "Сменить обивку сидений в салоне?")]
        public bool Lining { get; set; }
    }
}