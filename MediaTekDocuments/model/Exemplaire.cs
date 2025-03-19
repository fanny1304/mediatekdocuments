using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Exemplaire (exemplaire d'une revue)
    /// </summary>
    public class Exemplaire
    {
        public int Numero { get; set; }
        public string Photo { get; set; }
        public DateTime DateAchat { get; set; }
        public string IdEtat { get; set; }
        public string Id { get; set; }
        public string Libelle { get; set; }
        
        /// <summary>
        /// Constructeur de la classe Exemplaire
        /// </summary>
        /// <param name="numero">numéro de l'exemplaire</param>
        /// <param name="dateAchat">date d'achat de l'exemplaire</param>
        /// <param name="photo">photo de l'exemplaire</param>
        /// <param name="idEtat">id de l'état de l'exemplaire</param>
        /// <param name="idDocument">id du document</param>
        /// <param name="libelle">libellé de l'état de l'exemplaire</param>
        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument, string libelle)
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = idEtat;
            this.Id = idDocument;
            this.Libelle = libelle;
        }

    }
}
