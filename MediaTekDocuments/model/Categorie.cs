
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Categorie (réunit les informations des classes Public, Genre et Rayon)
    /// </summary>
    public class Categorie
    {
        public string Id { get; }
        public string Libelle { get; }

        /// <summary>
        /// Constructeur de la classe Categorie
        /// </summary>
        /// <param name="id">id de la catégorie</param>
        /// <param name="libelle">libellé de la catégorie</param>
        public Categorie(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Récupération du libellé pour l'affichage dans les combos
        /// </summary>
        /// <returns>Libelle</returns>
        public override string ToString()
        {
            return this.Libelle;
        }

    }
}
