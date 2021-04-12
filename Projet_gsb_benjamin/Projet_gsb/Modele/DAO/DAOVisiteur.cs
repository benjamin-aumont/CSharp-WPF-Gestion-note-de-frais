using JsonFx.Serialization;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Documents;

namespace Projet_gsb_Cath_Ben_Franck_Glad.Modele.DAO
{
    class DAOVisiteur
    {
        
        //fonction pour combobox comboNom >> Liste les Personnes de la BDD
        public static List<string> LesNomsVisiteurs()
        {
            List<string> LesNomsVisiteurs = new List<string>();
            using SqlCommand command = Connexion.GetInstance().CreateCommand();
           try
            {
                string Query = "select nom from Personne";
                command.CommandText = Query;
               using SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string nom = dataReader.GetString("nom");
                    LesNomsVisiteurs.Add(nom);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return LesNomsVisiteurs;
        }

        // Liste les Libellés Etat des Fiche de Frais
        public static List<string> LesLibelle()
        {
            List<string> LesLibelle = new List<string>();
            using SqlCommand command = Connexion.GetInstance().CreateCommand();
            try
            {
                string Query = "select libelle from Etat";
                command.CommandText = Query;
                using SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string nom = dataReader.GetString("libelle");
                    LesLibelle.Add(nom);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return LesLibelle;
            
        }

        // Liste les Libellés Etat des Fiche de Frais
        public static List<string> LesLibelle2()
        {
            List<string> LesLibelle2 = new List<string>();
           using SqlCommand command = Connexion.GetInstance().CreateCommand();
            try
            {
                string Query = "select libelle from Etat";
                command.CommandText = Query;
                using SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string nom = dataReader.GetString("libelle");
                    LesLibelle2.Add(nom);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return LesLibelle2;
           
        }


    }
}
