using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_gsb.Personne
{
    public class Visiteur : Personne
    {
        //Constructeur de la classe concrete héritant de celle abstraire Personne
        public Visiteur(int id, string nom, string prenom, string adresse, string reference, string login, string mdp, string cp, string ville, string dateEmbauche) : base(id, nom, prenom, adresse, reference, login, mdp, cp, ville, dateEmbauche)
        {
        }

    }
}
