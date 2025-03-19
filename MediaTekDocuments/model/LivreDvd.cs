
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier LivreDvd hérite de Document
    /// </summary>
    public abstract class LivreDvd : Document
    {
        /// <summary>
        /// Constructeur de la classe LivreDvd
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
        protected LivreDvd(string id, string titre, string image, string idGenre, string genre,
            string idPublic, string lePublic, string idRayon, string rayon)
            : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
        }

    }
}
