using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlFahimCMS.Models;
using AlFahimCMS.ViewModels;
namespace AlFahimCMS.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Process = "false";
            var ViewModel = new SearhItemViewModel
          {
            
            };
            return View("CreateOrder");
        }


        [HttpGet]
        public ActionResult ViewOrders()
        {


            var ViewModel = new ViewOrdersViewModel 
            {
                lViewOrders = new List<ViewOrders >
                {

                    new ViewOrders { OrderNumber="00001",OrderDate ="14/05/2017",Customer="Saleem",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00002",OrderDate ="14/05/2017",Customer="Micheal",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00003",OrderDate ="15/05/2017",Customer="Imran",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00004",OrderDate ="16/05/2017",Customer="Tariq",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00005",OrderDate ="17/05/2017",Customer="Sohail",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00006",OrderDate ="17/05/2017",Customer="George Ahmed",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00007",OrderDate ="17/05/2017",Customer="Kaleem Al Samee",SalesMan="Andrew",Status="Open"},
                    new ViewOrders { OrderNumber="00008",OrderDate ="20/05/2017",Customer="Mohammed Al Samee",SalesMan="Andrew",Status="Open"},


                }
            };
            return View(ViewModel);
           
        }

        [HttpGet]
        public ActionResult ViewOrdersDetail()
        {
            var ViewModel = new ViewOrdersDetailViewModel 
            {
                lOrdersDetail = new List<ViewOrdersDetail>
                {

                    new ViewOrdersDetail { ItemNumber="00001",ItemName ="Drill Machine Low",Qty=2},
                    new ViewOrdersDetail { ItemNumber="00002",ItemName ="Drill Machine High",Qty=2},
                    new ViewOrdersDetail { ItemNumber="00003",ItemName ="Oil Filter",Qty=11},


                }
            };
            return View  ("_ViewOrderDetail", ViewModel);

        }


        [HttpPost]
        public ActionResult CreateOrder()
        {

            //List<SeachItems> obj = new List<SeachItems>
            // {
            //   new SeachItems { ItemNumber="00001",ItemName="Drill Machine Low",Stock=10,Qty=0},
            // new SeachItems { ItemNumber="00002",ItemName="Drill Machine High",Stock=200,Qty=0},
            // new SeachItems { ItemNumber="00003",ItemName="Drill Machine Oil Filter",Stock=30,Qty=0},
            // new SeachItems { ItemNumber="00004",ItemName="Drill Machine Linear",Stock=20,Qty=0},

            // };


         
            var ViewModel = new SearhItemViewModel
            {
                lSearchItem = new List<SearchItem>
                {

                    new SearchItem { ItemNumber="00001",ItemName="Drill Machine Low",Stock=10,Qty=0},
                    new SearchItem { ItemNumber="00002",ItemName="Drill Machine High",Stock=200,Qty=0},
                    new SearchItem { ItemNumber="00003",ItemName="Drill Machine Oil Filter",Stock=30,Qty=0},
                    new SearchItem { ItemNumber="00004",ItemName="Drill Machine Linear",Stock=20,Qty=0},

                }
            };


            ViewBag.Process = "true";
            return View("CreateOrder", ViewModel);
        }

        [HttpPost]
        public ActionResult SaveOrder(SearhItemViewModel model)
        {
          //  foreach (var item in model.lSeachItems)
            //{



            //}
            ViewBag.Process = "SaveOk";
            return View("CreateOrder");
        }
    }
}