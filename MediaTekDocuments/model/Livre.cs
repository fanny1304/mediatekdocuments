
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Livre hérite de LivreDvd : contient des propriétés spécifiques aux livres
    /// </summary>
    public class Livre : LivreDvd
    {
        public string Isbn { get; }
        public string Auteur { get; }
        public string Collection { get; }

        /// <summary>
        /// Constructeur de la classe Livre
        /// </summary>
        /// <param name="id">id du document</param>
        /// <param name="titre">titre du document</param>
        /// <param name="image">image du document</param>
        /// <param name="isbn">isbn du livre</param>
        /// <param name="auteur">auteur du livre</param>
        /// <param name="collection">collection du livre</param>
        /// <param name="idGenre">id du genre du document</param>
        /// <param name="genre">libellé du genre du document</param>
        /// <param name="idPublic">id du public du document</param>
        /// <param name="lePublic">libellé du public du document</param>
        /// <param name="idRayon">id du rayon du document</param>
        /// <param name="rayon">libellé du rayon du document</param>
        public Livre(string id, string titre, string image, string isbn, string auteur, string collection,
            string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
            : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
            this.Isbn = isbn;
            this.Auteur = auteur;
            this.Collection = collection;
        }



    }
}
