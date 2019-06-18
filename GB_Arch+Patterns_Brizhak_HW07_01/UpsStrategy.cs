namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    /// <summary>
    /// Класс определяющий стратегию вычисления издержек через  Ups
    /// </summary>
    public class UpsStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => 4;
    }
}
