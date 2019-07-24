using System;

namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    /// <summary>
    /// Класс выбора стратегии
    /// </summary>
    public class StrategyCostCalculation
    {
        private readonly IShippingStrategy _strategyShipping;

        public StrategyCostCalculation(IShippingStrategy strategyShipping)
        {
            _strategyShipping = strategyShipping ?? throw new ArgumentNullException(nameof(strategyShipping));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public double CalculateShippingCost(Order order)
        {
            return _strategyShipping.Calculate(order);
        }
    }
}
