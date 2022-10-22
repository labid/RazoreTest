using ApplicationFormationAspNetRazoe.Core.Data.Models;
using ApplicationFormationAspNetRazoe.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationFormationAspNetRazoe.Controllers
{
    public class AventureController : Controller
    {

        public AventureController() : base()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
