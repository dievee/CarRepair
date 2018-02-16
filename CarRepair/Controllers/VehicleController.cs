using CarRepair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRepair.Controllers
{
    public class VehicleController : BaseController
    {
        // GET: Vehicle
        public ActionResult Repair()
        {

           return PartialView("_VehicleRepair");
        }
        [HttpPost]
        public ActionResult Calculate(Vehicle vehicle)
        {
            ViewBag.repairCost = GetRepairCost(vehicle);
            ViewBag.carCondition = GetCarCondition(vehicle);

            return View();
        }
    }
}