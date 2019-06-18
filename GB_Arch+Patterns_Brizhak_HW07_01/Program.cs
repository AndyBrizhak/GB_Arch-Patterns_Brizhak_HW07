using System;

// ДЗ к уроку 7 по курсу "Архитектуры и шаблоны проектирования " Брижак Андрей 
// 1. Реализовать шаблон «Стратегия» без использования делегатов.
// При решении задачи следует
// использовать следующий интерфейс:
//public interface IShippingStrategy
//{
//    double Calculate(Order order);
//}


namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order();
            UpsStrategy upsStrategy = new UpsStrategy();
            var cost = new StrategyCostCalculation(upsStrategy).CalculateShippingCost(order1);
            Console.WriteLine(cost);
            Console.ReadKey();
        }
    }
}
