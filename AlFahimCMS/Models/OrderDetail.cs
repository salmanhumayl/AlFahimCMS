using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlFahimCMS.Models
{
    public class OrderDetail
    {
        public string OrderID { get; set; }
        public string Itemid { get; set; }
        public Decimal  Qty { get; set; }



    }
}