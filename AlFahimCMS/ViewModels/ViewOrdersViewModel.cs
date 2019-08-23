using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlFahimCMS.ViewModels
{
    public class ViewOrdersViewModel
    {

        public List<ViewOrders> lViewOrders { get; set; }

    }

   
    public class ViewOrders
    {
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string Customer { get; set; }
        public String SalesMan { get; set; }
        public string Status { get; set; }
    }


    public class ViewOrdersDetailViewModel
    {

        public List<ViewOrdersDetail> lOrdersDetail { get; set; }

    }


    public class ViewOrdersDetail
    {
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public double  Qty { get; set; }
        
    }

}