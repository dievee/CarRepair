using CarRepair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRepair.Controllers
{
    public class TruckController : BaseController
    {
        // GET: Truck
        public ActionResult Repair()
        {

            return PartialView("_TruckRepair");
        }
        [HttpPost]
        public ActionResult Calculate(Truck truck)
        {
            ViewBag.repairCost = GetRepairCost(truck);
            ViewBag.carCondition = GetCarCondition(truck);

            return View();
        }
    }
}