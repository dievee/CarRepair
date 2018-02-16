using CarRepair.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRepair.Controllers
{
    public class BusController : BaseController
    {
        // GET: Bus
        public ActionResult Repair()
        {

            return PartialView("_BusRepair");
        }
        [HttpPost]
        public ActionResult Calculate(Bus bus)
        {
            //register in db..
            ViewBag.repairCost = GetRepairCost(bus);
            ViewBag.carCondition = GetCarCondition(bus);

            return View();
        }
    }
}