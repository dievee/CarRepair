using System;

namespace CarRepair.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ServiceCostAttribute : Attribute
    {
        public ServiceCostAttribute(int cost)
        {
            Cost = cost;
        }
        public int Cost { get; set; }
    }
}