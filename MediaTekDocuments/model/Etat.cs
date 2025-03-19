
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Etat (état d'usure d'un document)
    /// </summary>
    public class Etat
    {
        public string Id { get; set; }
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe Etat
        /// </summary>
        /// <param name="id">id de l'état</param>
        /// <param name="libelle">libellé de l'état</param>
        public Etat(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

    }
}
