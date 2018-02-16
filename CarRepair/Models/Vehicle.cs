using CarRepair.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRepair.Models
{
    public class Vehicle : Car
    {
        [ServiceCost(100)]
        [Display(Name = "Провести балансировку колес ?")]
        public bool WheelsBalance { get; set; }
    }
}