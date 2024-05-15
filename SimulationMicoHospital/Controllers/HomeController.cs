using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace SimulationMicoHospital.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
