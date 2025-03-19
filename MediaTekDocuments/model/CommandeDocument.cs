using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeDocument
    /// </summary>
    public class CommandeDocument : Commande
    {
        public int NbExemplaire { get; set; }

        public string IdLivreDvd { get; set; }

        public string IdSuivi { get; set; }

        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe commande document
        /// </summary>
        /// <param name="id">id de la commande</param>
        /// <param name="dateCommande">date de la commande</param>
        /// <param name="montant">montant de la commande</param>
        /// <param name="nbExemplaire">nb d'exemplaire(s) commandé(s)</param>
        /// <param name="idLivreDvd">id du livre ou du dvd concerné</param>
        /// <param name="idSuivi">id du suivi de la commande</param>
        /// <param name="libelle">libellé du suivi de la commande</param>
        public CommandeDocument(string id, DateTime dateCommande, double montant, int nbExemplaire, 
                                string idLivreDvd, string idSuivi, string libelle)
            : base(id, dateCommande, montant)
        {
            this.NbExemplaire = nbExemplaire;
            this.IdLivreDvd = idLivreDvd;
            this.IdSuivi = idSuivi;
            this.Libelle = libelle;
        }
    }
}
