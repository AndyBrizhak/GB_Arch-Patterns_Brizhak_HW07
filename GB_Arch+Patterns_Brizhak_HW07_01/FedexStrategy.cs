﻿namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    /// <summary>
    /// Класс определяющий стратегию вычисления издержек через Fedex
    /// </summary>
    public class FedexStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => 5;
    }
}
