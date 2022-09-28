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
            List <Aventure> aventures = new List<Aventure>();

            aventures.Add(new Aventure()
            {
                Id = 1,
                Titre = "Premiere aventure"
            });

            aventures.Add(new Aventure()
            {
                Id = 2,
                Titre = "2eme aventure"
            });

            return View(aventures);
        }

    }
}
