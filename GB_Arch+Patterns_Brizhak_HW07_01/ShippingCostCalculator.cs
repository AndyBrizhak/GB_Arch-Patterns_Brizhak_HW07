﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    public class ShippingCostCalculator
    {
        public double Calculate(Order order, Func<Order, double> shippingCostStrategy) => shippingCostStrategy(order);
    }
}
