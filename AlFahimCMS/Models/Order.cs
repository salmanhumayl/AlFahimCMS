using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlFahimCMS.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public int  OrderID { get; set; }
        public string OrderDate { get; set; }
        public int CustomerID { get; set; }
        public Decimal Total { get; set; }

    }
}