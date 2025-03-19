using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Service
    /// </summary>
    public class Service
    {
        public string Id { get; set; }
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe Service
        /// </summary>
        /// <param name="id">id du service</param>
        /// <param name="libelle">libellé du service</param>
        public Service(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
    }
}
