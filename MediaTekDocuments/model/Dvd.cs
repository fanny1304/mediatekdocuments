
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Dvd hérite de LivreDvd : contient des propriétés spécifiques aux dvd
    /// </summary>
    public class Dvd : LivreDvd
    {
        public int Duree { get; }
        public string Realisateur { get; }
        public string Synopsis { get; }

        /// <summary>
        /// Constructeur de la classe Dvd
        /// </summary>
        /// <param name="id">id du document</param>
        /// <param name="titre">titre du document</param>
        /// <param name="image">image du document</param>
        /// <param name="duree">durée du dvd</param>
        /// <param name="realisateur">réalisateur du dvd</param>
        /// <param name="synopsis">synopsis du dvd</param>
        /// <param name="idGenre">id du genre du document</param>
        /// <param name="genre">libellé du genre du document</param>
        /// <param name="idPublic">id du public du document</param>
        /// <param name="lePublic">libellé du public du document</param>
        /// <param name="idRayon">id du rayon du document</param>
        /// <param name="rayon">libellé du rayon du document</param>
        public Dvd(string id, string titre, string image, int duree, string realisateur, string synopsis,
            string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
            : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
            this.Duree = duree;
            this.Realisateur = realisateur;
            this.Synopsis = synopsis;
        }

    }
}
