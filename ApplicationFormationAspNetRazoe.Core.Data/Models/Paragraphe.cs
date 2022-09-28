using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFormationAspNetRazoe.Core.Data.Models
{
    public class Paragraphe
    {
        #region Propriétés
        /// <summary>
        /// Identifiant de paragraphe
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Numéro de paraghraphe
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Titre de paraghraphe
        /// </summary>
        public string Titre { get; set; } 
        /// <summary>
        /// Desciption de paraghraphe
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Classe question
        /// </summary>
        public Question Question { get; set; }

        #endregion
    }
}
