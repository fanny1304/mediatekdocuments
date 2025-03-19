
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Document (réunit les infomations communes à tous les documents : Livre, Revue, Dvd)
    /// </summary>
    public class Document
    {
        public string Id { get; }
        public string Titre { get; }
        public string Image { get; }
        public string IdGenre { get; }
        public string Genre { get; }
        public string IdPublic { get; }
        public string Public { get; }
        public string IdRayon { get; }
        public string Rayon { get; }

        /// <summary>
        /// Constructeur de la classe Document
        /// </summary>
        /// <param name="id">id du document</param>
        /// <param name="titre">titre du document</param>
        /// <param name="image">image du document</param>
        /// <param name="idGenre">id du genre du document</param>
        /// <param name="genre">libellé du genre du document</param>
        /// <param name="idPublic">id du public du document</param>
        /// <param name="lePublic">libellé du public du document</param>
        /// <param name="idRayon">id du rayon du document</param>
        /// <param name="rayon">libellé du rayon du document</param>
        public Document(string id, string titre, string image, string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
        {
            Id = id;
            Titre = titre;
            Image = image;
            IdGenre = idGenre;
            Genre = genre;
            IdPublic = idPublic;
            Public = lePublic;
            IdRayon = idRayon;
            Rayon = rayon;
        }
    }
}
