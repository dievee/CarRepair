using CarRepair.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using CarRepair.Code;

namespace CarRepair.Controllers
{
    public class BaseController : Controller, IRepairCalculator
    {
        public int GetRepairCost<T>(T car)
        {
            int propertyValuesSum = 0;
            int intReturnPropertiesCount = 0;
            int additionalRepairCost = 0;

            foreach (var property in typeof(T).GetProperties())
            {
                PropertyInfo pi = typeof(T).GetProperty(property.Name);

                switch (property.PropertyType.Name)
                {
                    case "Int32":
                        intReturnPropertiesCount++;
                        propertyValuesSum += (int)pi.GetValue(car);
                        break;

                    case "Boolean":
                        if ((bool)pi.GetValue(car))
                        {
                            var attributeValue = pi.GetCustomAttribute(typeof(ServiceCostAttribute)) as ServiceCostAttribute;
                            additionalRepairCost += attributeValue.Cost;
                        }
                        break;
                    default:
                        throw new ArgumentException("Allows only Int32 and Bool properties");
                }
            }

            return (intReturnPropertiesCount * 100 - propertyValuesSum) * 10 + additionalRepairCost;
        }
        public int GetCarCondition<T>(T car)
        {
            int propertyValuesSum = 0;
            int intReturnPropertiesCount = 0;

            foreach (var property in typeof(T).GetProperties())
            {
                PropertyInfo pi = typeof(T).GetProperty(property.Name);

                switch (property.PropertyType.Name)
                {
                    case "Int32":
                        intReturnPropertiesCount++;
                        propertyValuesSum += (int)pi.GetValue(car);
                        break;

                    case "Boolean":
                        break;
                    default:
                        throw new ArgumentException("Allows only Int32 and Bool properties");
                }
            }

            return propertyValuesSum / intReturnPropertiesCount;
        }
    }
}