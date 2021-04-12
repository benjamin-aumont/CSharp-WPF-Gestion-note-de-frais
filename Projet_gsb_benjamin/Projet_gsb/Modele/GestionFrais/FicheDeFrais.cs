using Projet_gsb.GestionFrais;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFrais
{

    public class FicheDeFrais : IFicheDeFrais
    {
        // Attribut privés d'une fiche de frais
        private int id;
        private string mois;
        private float montantValide;
        private int idEtat;
        private int idVisiteur;
        private int repas;
        private int nuitee;
        private int km;
        private float montantTotal;


        //Constructeur d'une Fiche de Frais
        public FicheDeFrais(string mois, float montantValide, int idEtat, int idVisiteur, int nuitee, int km, int repas, float montantTotal)
        {
            //this.id = id;
            this.mois = mois;
            this.montantValide = montantValide;
            this.idEtat = idEtat;
            this.idVisiteur = idVisiteur;
            this.nuitee = nuitee;
            this.km = km;
            this.repas = repas;
            this.montantTotal = montantTotal;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Km
        {
            get { return km; }
            set { km = value; }
        }

        public int Nuitee
        {
            get { return nuitee; }
            set { nuitee = value; }
        }

        public float MontantTotal
        {
            get { return montantTotal; }
            set { montantTotal = value; }
        }


        public string Mois
        {
            get { return mois; }
            set { mois = value; }
        }

        public float MontantValide
        {
            get { return montantValide; }
            set { montantValide = value; }
        }

        public int IdEtat
        {
            get { return idEtat; }
            set { idEtat = value; }
        }
        public int IdVisiteur
        {
            get { return idVisiteur; }
            set { idVisiteur = value; }
        }

        public int Repas
        {
            get { return repas; }
            set { repas = value; }
        }

       
    }
   
}