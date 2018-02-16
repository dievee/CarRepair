using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRepair.Controllers;
using CarRepair.Models;

namespace CarRepair.Tests.Controllers
{
    [TestClass]
    public class BaseControllerTest
    {

        [TestMethod]
        public void GetRepairCostEmptyCarObject()
        {
            BaseController controller = new BaseController();

            var result = controller.GetRepairCost(new Bus() );

            Assert.AreEqual(7000, result);
        }

        [TestMethod]
        public void GetCarConditionEmptyCarObject()
        {
            BaseController controller = new BaseController();

            var result = controller.GetCarCondition(new Bus());

            Assert.AreEqual(0, result);
        }

    }
}
