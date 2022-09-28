using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFormationAspNetRazoe.Core.Data.Models
{

    public class Reponse
    {
        #region Propriétés
        /// <summary>
        /// Identifiant
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Titre
        /// </summary>
        public string Titre { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
