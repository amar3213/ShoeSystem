using System;

namespace ShoeClasses
{
    public class clsOrder
    {
        public DateTime OrderDate { get; set; }
        public int OrderAddress { get; set; }
        public string CustomerName { get; set; }
        public string OrderItem { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
    }
}