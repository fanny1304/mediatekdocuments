using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Abonnement (hérite de Commande)
    /// </summary>
    public class Abonnement : Commande
    {
        public DateTime DateFinAbonnement { get; set; }

        public string IdRevue { get; set; }

        public string Titre { get; set; }

        /// <summary>
        /// Constructeur de la classe Abonnement
        /// </summary>
        /// <param name="id">id de l'abonnement</param>
        /// <param name="dateCommande">date de la commande</param>
        /// <param name="montant">montant de la commande</param>
        /// <param name="dateFinAbonnement">date de fin d'abonnement</param>
        /// <param name="idRevue">id de la revue concernée</param>
        /// <param name="titre">titre de la revue concernée</param>
        public Abonnement(string id, DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue, string titre)
            : base(id, dateCommande, montant)
        {
            this.DateFinAbonnement = dateFinAbonnement;
            this.IdRevue = idRevue;
            this.Titre = titre;
        }
    }
}
