using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Utilisateur 
    /// </summary>
    public class Utilisateur
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string IdService { get; set; }
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur de la classe Utilisateur
        /// </summary>
        /// <param name="login">login de l'utilisateur</param>
        /// <param name="password">mot de passe de l'utilisateur</param>
        /// <param name="idService">id du service de l'utilisateur</param>
        /// <param name="libelle">libellé de l'utilisateur</param>
        public Utilisateur(string login, string password, string idService, string libelle)
        {
            this.Login = login;
            this.Password = password;
            this.IdService = idService;
            this.Libelle = libelle;
        }
    }
}


