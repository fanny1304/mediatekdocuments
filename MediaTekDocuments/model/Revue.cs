
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Revue hérite de Document : contient des propriétés spécifiques aux revues
    /// </summary>
    public class Revue : Document
    {
        public string Periodicite { get; set; }
        public int DelaiMiseADispo { get; set; }

        /// <summary>
        /// Constructeur de la classe Revue
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
        /// <param name="periodicite">périodicité de la revue</param>
        /// <param name="delaiMiseADispo">délai de mise à dispo de la revue</param>
        public Revue(string id, string titre, string image, string idGenre, string genre,
            string idPublic, string lePublic, string idRayon, string rayon,
            string periodicite, int delaiMiseADispo)
             : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
            Periodicite = periodicite;
            DelaiMiseADispo = delaiMiseADispo;
        }

    }
}
