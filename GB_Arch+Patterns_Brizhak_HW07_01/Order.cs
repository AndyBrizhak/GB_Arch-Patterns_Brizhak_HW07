using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_Brizhak_HW07_01
{
    public class Order
    {
        public ShippingOptions ShippingMethod { get; set; }

        public Address Destination { get; set; }

        public Address Origin { get; set; }
    }
}
