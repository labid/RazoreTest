using ApplicationFormationAspNetRazoe.BackOffice.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApplicationFormationAspNetRazoe.BackOffice.Web.UI.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}