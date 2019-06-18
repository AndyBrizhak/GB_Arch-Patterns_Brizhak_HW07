using System;

namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    public class ShippingCostCalculator
    {
        public double Calculate(Order order, Func<Order, double> shippingCostStrategy) => shippingCostStrategy(order);
    }
}
