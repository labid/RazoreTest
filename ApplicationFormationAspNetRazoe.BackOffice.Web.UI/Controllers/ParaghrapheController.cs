using ApplicationFormationAspNetRazoe.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationFormationAspNetRazoe.BackOffice.Web.UI.Controllers
{
    public class ParaghrapheController : Controller
    {
        public IActionResult Index()
        {
            Paragraphe paragraphe = new Paragraphe()
            {
                Id = 1,
                Numero = 1,
                Titre = "Titre de Paraghraphe 1",
                Description = "La meilleur description dans le paraghraphe",
                Question = new Question() { Id = 1,Title="Question 1",Reponse = new List<Reponse>()}
            };

            paragraphe.Question.Reponse.Add(new Reponse()
            {
                Id = 1,
                Titre = "Réponse 1",
                Description = "Ha 3lach"
            });

            paragraphe.Question.Reponse.Add(new Reponse()
            {
                Id = 2,
                Titre = "Réponse 2",
                Description = "la 79ach"
            });



            return View(paragraphe);
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
