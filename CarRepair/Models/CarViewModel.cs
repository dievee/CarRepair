using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRepair.Models
{
    public class CarViewModel
    {
        public ArrayList Types { get; set; }
        //= new List<SelectListItem>();

        public CarViewModel()
        {
            //var ccc = typeof(CarViewModel).GetProperties();
            this.GetProperties();

        }

        public void GetProperties()
        {
            //foreach (var i in typeof(CarViewModel).GetProperties())
                //Types.Add(i.GetType());

        }

        public Bus Bus { get; set; }
        public Truck Truck { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}