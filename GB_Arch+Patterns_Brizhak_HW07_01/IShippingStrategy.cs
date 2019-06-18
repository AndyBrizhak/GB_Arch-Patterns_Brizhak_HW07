namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    /// <summary>
    /// Интерфейс, определяющий стратегию расчеты издержек
    /// </summary>
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}
