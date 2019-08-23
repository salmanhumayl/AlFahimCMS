using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlFahimCMS.Models;

namespace AlFahimCMS.ViewModels
{
    public class OrderDetailViewModel
    {
        public List<OrderDetail> lOrderDetail { get; set; }


    }
    public class SearhItemViewModel
    {
        public List<SearchItem> lSearchItem { get; set; }


    }

    public class SearchItem
    {
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public Decimal Stock { get; set; }
        public Decimal  Qty { get; set; }
    }
}