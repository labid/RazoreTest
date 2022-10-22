using ApplicationFormationAspNetRazoe.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationFormationAspNetRazoe.BackOffice.Web.UI.Controllers
{
    public class ParaghrapheController : Controller
    {
        public IActionResult Index()
        {
             

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Paragraphe paragraph)
        {
            Paragraphe p = paragraph;
            return View(p);
        }
    }
}
