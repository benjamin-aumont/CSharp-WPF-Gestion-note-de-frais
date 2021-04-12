using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_gsb.Personne
{
    //Classe abstratire hériatnt de l'interface IPersonne
    public abstract class Personne : IPersonne
    {
        //Attributs privés d'une personne
        private int id;
        private string reference;
        private string login;
        private string mdp;
        private string cp;
        private string ville;
        private string dateEmbauche;
        private string nom;
        private string prenom;
        private string adresse;
        private bool comptable = false;

        //Constructeur 
        protected Personne(int id, string nom, string prenom, string adresse, string reference, string login, string mdp, string cp, string ville, string dateEmbauche)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
            this.Reference = reference;
            this.Login = login;
            this.Mdp = mdp;
            this.Cp = cp;
            this.Ville = ville;
            this.DateEmbauche = dateEmbauche;
        }

        public bool Comptable
        {
            get { return comptable; }
            set { comptable = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public string DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

    
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }      

    }
}
