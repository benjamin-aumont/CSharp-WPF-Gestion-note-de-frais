using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_gsb.GestionFrais
{
    public abstract class LigneDeFrais
    {
        //Attribut Protégé d'une ligne de Frais
        protected int idLigneDeFrais;
        protected int idVisiteur;
        protected string mois;

        //Constructeur
        protected LigneDeFrais(int idLigneDeFrais, int idVisiteur, string mois)
        {
            this.idLigneDeFrais = idLigneDeFrais;
            this.idVisiteur = idVisiteur;
            this.mois = mois;
        }

        public int Id
        {
            get { return idLigneDeFrais; }
            set { idLigneDeFrais = value; }
        }

        public int IdVisiteur
        {
            get { return idVisiteur; }
            set { idVisiteur = value; }
        }

        public string Mois
        {
            get { return mois; }
            set { mois = value; }
        }


    }
}