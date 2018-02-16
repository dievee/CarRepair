using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepair.Code
{
    interface IRepairCalculator
    {
        int GetRepairCost<T>(T car);

        int GetCarCondition<T>(T car);
    }
}
