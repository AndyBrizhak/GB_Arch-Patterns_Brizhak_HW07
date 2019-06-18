using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    public class StrategyCostCalculation
    {
        private readonly IShippingStrategy _strategyShipping;

        public StrategyCostCalculation(IShippingStrategy strategyShipping)
        {
            _strategyShipping = strategyShipping ?? throw new ArgumentNullException(nameof(strategyShipping));
        }

        public double CalculateShippingCost(Order order)
        {
            return _strategyShipping.Calculate(order);
        }
    }
}
