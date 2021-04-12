using Projet_gsb.GestionFrais;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_gsb_Cath_Ben_Franck_Glad.Modele.GestionFrais
{
    public class LigneFraisHorsForfait 
    {
        //Attribut privé Ligne Frais Hors Forfait
        private int idLigneDeFrais;
        private int idVisiteur;
        private string mois;
        private string libelle;
        private string date;
        private float montant;

        //Constructeur
        public LigneFraisHorsForfait(int idLigneDeFrais, int idVisiteur, string mois, string libelle, string date, float montant)
        {
            this.idLigneDeFrais = idLigneDeFrais;
            this.idVisiteur = idVisiteur;
            this.mois = mois;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant;
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

        public string Mois
        {
            get { return mois; }
            set { mois = value; }
        }

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        public string  Date
        {
            get { return date; }
            set { date = value; }
        }

        public float Montant
        {
            get { return montant; }
            set { montant = value; }
        }

    }
}
