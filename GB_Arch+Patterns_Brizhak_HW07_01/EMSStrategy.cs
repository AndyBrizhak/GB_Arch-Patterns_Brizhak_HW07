namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    /// <summary>
    /// Класс определяющий стратегию вычисления издержек через EMS
    /// </summary>
    public class EmsStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => 3;
    }
}
