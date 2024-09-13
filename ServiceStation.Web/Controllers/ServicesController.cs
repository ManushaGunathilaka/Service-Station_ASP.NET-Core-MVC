using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; } //use attribute
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            PageTitle = "Service Details"; //add title to attribute

            var service = new VehicleService
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Cost = 33.99
            };

            return View(service);
        }
    }
}
