using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Commande 
    /// </summary>
    public class Commande
    {
        public string Id { get; set; }

        public DateTime DateCommande { get; set; }

        public double Montant { get; set; }

        /// <summary>
        /// Constructeur de la classe Commande
        /// </summary>
        /// <param name="id">id de la commande</param>
        /// <param name="dateCommande">date de la commande</param>
        /// <param name="montant">montant de la commande</param>
        public Commande(string id, DateTime dateCommande, double montant)
        {
            this.Id = id;
            this.DateCommande = dateCommande;
            this.Montant = montant;
        }

    }
}
