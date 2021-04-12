using GestionFrais;
using JsonFx.Serialization;
using LinqToDB.Data;
using Projet_gsb.GestionFrais;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Documents;

namespace Projet_gsb_Cath_Ben_Franck_Glad.Modele.DAO
{
    class DAOFicheFrais
    {
        //Méthode Lecture de Fiche de Frais
        public Projet_gsb.GestionFrais.IFicheDeFrais Read(int id)
        {
            IFicheDeFrais ficheFrais = null;
            SqlCommand commandR = Connexion.GetInstance().CreateCommand();
            commandR.CommandText = "SELECT * FROM FicheFrais where id=@id";

            // Lecture des résultats
            SqlDataReader dataReader = commandR.ExecuteReader();

            if (dataReader.Read())
            {
 
                string mois = (string)dataReader["mois"];
                float montantValide = (float)dataReader["montantValide"];
                int idEtat = (int)dataReader["idEtat"];
                int idVisiteur = (int)dataReader["idVisiteur"];
                int nuitee = (int)dataReader["nuitee"];
                int km = (int)dataReader["km"];
                int repas = (int)dataReader["repas"];
                float montantTotal = (float)dataReader["montantTotal"];

                ficheFrais = new FicheDeFrais(mois, montantValide, idEtat, idVisiteur, nuitee, km, repas, montantTotal);
                dataReader.Close();
            }
            return ficheFrais;
        }

        //Création de Fiche de Frais
        public static void Create(FicheDeFrais FicheFrais)
        {
            SqlCommand commandC = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            commandC.CommandText = "INSERT INTO FicheFrais ( mois, montantValide, idEtat, idVisiteur, nuitee, km, repas, montantTotal) VALUES (@mois,@montantValide, @idEtat, @idVisiteur, @nuitee, @km, @repas, @montantTotal)";
            // command.Parameters.AddWithValue("@id", FicheFrais.Id);
            commandC.Parameters.AddWithValue("@mois", FicheFrais.Mois);
            commandC.Parameters.AddWithValue("@montantValide", FicheFrais.MontantValide);
            commandC.Parameters.AddWithValue("@idEtat", FicheFrais.IdEtat);
            commandC.Parameters.AddWithValue("@idVisiteur", FicheFrais.IdVisiteur);
            commandC.Parameters.AddWithValue("@nuitee", FicheFrais.Nuitee);
            commandC.Parameters.AddWithValue("@km", FicheFrais.Km);
            commandC.Parameters.AddWithValue("@repas", FicheFrais.Repas);
            commandC.Parameters.AddWithValue("@montantTotal", FicheFrais.MontantTotal);
            //TODO bool compatble
            // Exécution de la requête
            commandC.ExecuteNonQuery();
        }

        //Suppression d'une fiche de Frais
        public static void Delete(int id)
        {
            SqlCommand commandD = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            commandD.CommandText = "DELETE FROM FicheFrais where id=@id";
            commandD.Parameters.AddWithValue("@id", id);
            // Exécution de la requête
            commandD.ExecuteNonQuery();
        }

        // Modification d'une fiche de frais >> syntaxe à revoir
        public static void Update(int id, FicheDeFrais FicheFrais)
        {
            SqlCommand commandU = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
          //  commandU.CommandText = "UPDATE FROM FicheFrais (id, mois, montantValide, idEtat, idVisiteur, nuitee, km, repas, montantTotal) VALUES (@'"+id+"',@mois,@montantValide, @idEtat, @idVisiteur, @nuitee, @km, @repas, @montantTotal)";
            commandU.CommandText = "UPDATE FicheFrais SET mois=@mois, montantValide=@montantValide, " +
                "idEtat=@idEtat, idVisiteur=@idVisiteur, nuitee=@nuitee, km=@km, repas=@repas, montantTotal=@montantTotal WHERE id=@id";
            commandU.Parameters.AddWithValue("@id", id);
            commandU.Parameters.AddWithValue("@mois", FicheFrais.Mois);
            commandU.Parameters.AddWithValue("@montantValide", FicheFrais.MontantValide);
            commandU.Parameters.AddWithValue("@idEtat", FicheFrais.IdEtat);                       
            commandU.Parameters.AddWithValue("@idVisiteur", FicheFrais.IdVisiteur);
            commandU.Parameters.AddWithValue("@nuitee", FicheFrais.Nuitee);
            commandU.Parameters.AddWithValue("@km", FicheFrais.Km);
            commandU.Parameters.AddWithValue("@repas", FicheFrais.Repas);
            commandU.Parameters.AddWithValue("@montantTotal", FicheFrais.MontantTotal);
            // Exécution de la requête
            commandU.ExecuteNonQuery();
        }

        public static void UpdateEtat(int id, int idEtat)
        {
            SqlCommand commandUEtat = Connexion.GetInstance().CreateCommand();
            commandUEtat.CommandText = "Update ficheFrais  SET IdEtat=@idEtat WHERE id=@id ";
            commandUEtat.Parameters.AddWithValue("@id", id);
            commandUEtat.Parameters.AddWithValue("@idEtat", idEtat);
            //executuion
            commandUEtat.ExecuteNonQuery();

        }

    }

 
    }

