using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_gsb.Personne
{
    public class Comptable  : Personne
    {
        //Constructeur héritant de la classe abstraite Personne
        public Comptable(int id, string nom, string prenom, string adresse, string reference, string login, string mdp, string cp, string ville, string dateEmbauche) : base(id, nom, prenom, adresse, reference, login, mdp, cp, ville, dateEmbauche)
        {
            Comptable = true;
        }
    }
}
