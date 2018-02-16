using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRepair.Models
{
    public abstract class Car
    {
        public readonly int repairCostOfOneComponent = 10;

        [Display(Name = "Состояние кузова:")]
        [Range(0, 100)]
        public int Body { get; set; }

        [Display(Name = "Состояние колес:")]
        [Range(0, 100)]
        public int Wheels { get; set; }

        [Display(Name = "Состояние двигателя:")]
        [Range(0, 100)]
        public int Engine { get; set; }

        [Display(Name = "Состояние тормозной системы:")]
        [Range(0, 100)]
        public int Brake { get; set; }

        [Display(Name = "Состояние ходовой части:")]
        [Range(0, 100)]
        public int Undercarriage { get; set; }

        [Display(Name = "Состояние салона:")]
        [Range(0, 100)]
        public int Interior { get; set; }
    }
}