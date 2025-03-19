using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Suivi 
    /// </summary>
    public class Suivi
    {
        public string Id { get; set; }
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe Suivi
        /// </summary>
        /// <param name="id">id du suivi</param>
        /// <param name="libelle">libellé du suivi</param>
        public Suivi(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
    }
}
