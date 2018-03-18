using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Q1()
        {

            RainierEntities model = new RainierEntities();
            ViewBag.Message = "Query One: How many of the top 10(score) titles are PC games?";

            var query1 = (from ign in model.igns
                         join vg in model.vgs
                         on ign.Title equals vg.Title
                         where vg.Platform == "PC"
                         select ign).Take(10);

            List<ign> IGNList = query1.ToList();

            return View(IGNList);
        }

        //SELECT TOP 10 IGN_Table.Score, NA_Sales, EU_Sales, Japan_Sales, Other_Sales, Global_Sales FROM IGN_Table JOIN VGSales_Table ON IGN_Table.Title = VGSales_Table.Title WHERE VGSales_Table.Platform = “PC”;


       
        //SELECT TOP 5 IGN_Table.Platform, NA_Sales, EU_Sales, Japan_Sales, Other_Sales, Global_Sales FROM VGSales_Table JOIN IGN_Table ON.VGSales_TableTitle = IGN_Table.Title JOIN SteamSpy_Table ON IGN_Table.title = SteamSpy_Table.Title;

        public ActionResult Q2()
        {

            RainierEntities model = new RainierEntities();
            ViewBag.Message = "Query Two: What are the platform(s) for top 5 selling games in ea.area?";

            var query2 = (from ign in model.igns
                          join vg in model.vgs on ign.Title equals vg.Title
                          join steamspy in model.steamspies on vg.Title equals steamspy.Title
                          select ign).Take(10);

            List<ign> IGNList = query2.ToList();

            return View(IGNList);
        }

        /*       public ActionResult Contact()
               {
                   NodeOrdersEntities model = new NodeOrdersEntities();
                   var query = from cd in model.CDTables
                               where cd.ListPrice > 10
                               select cd;
                   List<CDTable> list = query.ToList();

                   return View(list);
               }

               [HttpGet]
               public ActionResult GetDetails(int? id)
               {
                   NodeOrdersEntities model = new NodeOrdersEntities();
                   var query = (from person in model.SalesPersonTables
                                from order in person.Orders
                                where order.CdID == id
                                select person).Distinct().Take(20);
                   List<SalesPersonTable> DetailsList = query.ToList();
                   ViewBag.ID = id;
                   return View(DetailsList);

               }
               */
    }
}