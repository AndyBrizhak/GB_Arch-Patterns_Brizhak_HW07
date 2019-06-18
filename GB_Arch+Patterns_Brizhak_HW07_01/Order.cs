namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    public class Order
    {
        public ShippingOptions ShippingMethod { get; set; }

        public Address Destination { get; set; }

        public Address Origin { get; set; }
    }
}
