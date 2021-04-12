using Projet_gsb.GestionFrais;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_gsb_Cath_Ben_Franck_Glad.Modele.GestionFrais
{
    public class LigneFraisForfait
    {

        //Attributs privés d'une Ligne Frais Forfait
        private int idFicheDeFrais;
        private int idLigneDeFrais;
        private int idVisiteur;
        private string mois;

        //Constructeur
        public LigneFraisForfait(int idLigneDeFrais, int idVisiteur, string mois, int idFicheDeFrais)
        {
            this.idLigneDeFrais = idLigneDeFrais;
            this.idVisiteur = idVisiteur;
            this.mois = mois;
            this.idFicheDeFrais = idFicheDeFrais;
        }

        public int IdidFicheDeFrais
        {
            get { return idFicheDeFrais; }
            set { idFicheDeFrais = value; }
        }

        public int IdLigneDeFrais
        {
            get { return idLigneDeFrais; }
            set { idLigneDeFrais = value; }
        }

        public int IdVisiteur
        {
            get { return idVisiteur; }
            set { idVisiteur = value; }
        }

        public int Mois
        {
            get { return Mois; }
            set { Mois = value; }
        }


    }
}