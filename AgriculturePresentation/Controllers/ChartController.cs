using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();

            productClasses.Add(new ProductClass
                {
                Productname = "Buğday",
                Productvalue = 850
            });
            productClasses.Add(new ProductClass
            {
                Productname = "Mercimek",
                Productvalue = 480
            });
            productClasses.Add(new ProductClass
            {
                Productname = "Arpa",
                Productvalue = 250
            });
            productClasses.Add(new ProductClass
            {
                Productname = "Pirinç",
                Productvalue = 120
            });
            productClasses.Add(new ProductClass
            {
                Productname = "Domates",
                Productvalue = 960
            });
            return Json(new { jsonlist = productClasses });
        }
    }
}
