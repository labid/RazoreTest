using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFormationAspNetRazoe.Core.Data.Models
{
    public class Question
    {
        #region Question
        /// <summary>
        /// Identifiant Question
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Titre de question
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Liste des réponses possibles
        /// </summary>
        public List<Reponse> Reponse;
        #endregion
    }
}
