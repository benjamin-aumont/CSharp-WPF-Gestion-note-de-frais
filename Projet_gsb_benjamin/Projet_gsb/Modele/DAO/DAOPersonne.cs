using Projet_gsb.Personne;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projet_gsb_Cath_Ben_Franck_Glad.Modele.DAO
{
    public class DAOPersonne 
    {
        //Lecture d'une Personne
        public IPersonne Read(int id)
        {
            IPersonne personne = null;
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT * FROM Personne where id=@id";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
               
                string nom = (string)dataReader["nom"];
                string prenom = (string)dataReader["prenom"];
                string adresse = (string)dataReader["adresse"];
                string reference = (string)dataReader["reference"];
                string login = (string)dataReader["login"];
                string mdp = (string)dataReader["mdp"];
                string cp = (string)dataReader["cp"];
                string ville = (string)dataReader["ville"];
                string dateEmbauche = (string)dataReader["dateEmbauche"];

                bool comptable = (bool) dataReader["comptable"];
                if (comptable) { 
                    personne = new Comptable(id,nom, prenom,adresse,reference,login,mdp,cp,ville,dateEmbauche);
                }
                else
                {
                    personne = new Visiteur(id,nom,prenom,adresse,reference,login,mdp,cp,ville,dateEmbauche);
                }
            }
            dataReader.Close();

            return personne; 
        }

        //Création d'une personne
        public static void Create(Personne personne)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
           // command.CommandText = "INSERT INTO Personne (id,ref,nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES (@id,@ref,@nom, @prenom, @login, @mdp, @adresse, @cp, @ville, @dateEmbauche)";
            command.CommandText = "INSERT INTO Personne (ref,nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche, comptable) VALUES (@id,@ref,@nom, @prenom, @login, @mdp, @adresse, @cp, @ville, @dateEmbauche, @comptable)";
          //  command.Parameters.AddWithValue("@id", personne.Id);
            command.Parameters.AddWithValue("@ref", personne.Reference);
            command.Parameters.AddWithValue("@nom", personne.Nom);
            command.Parameters.AddWithValue("@prenom", personne.Prenom);
            command.Parameters.AddWithValue("@login", personne.Login);
            command.Parameters.AddWithValue("@mdp", personne.Mdp);
            command.Parameters.AddWithValue("@adresse", personne.Adresse);
            command.Parameters.AddWithValue("@cp", personne.Cp);
            command.Parameters.AddWithValue("@ville", personne.Ville);
            command.Parameters.AddWithValue("@dateEmbauche", personne.DateEmbauche);
            command.Parameters.AddWithValue("@comptable", personne.Comptable);
            // Exécution de la requête
            command.ExecuteNonQuery();
        }

        // Supression d'une petsonne
        public static void Delete(int id)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "DELETE FROM Personne where id=@id";
            command.Parameters.AddWithValue("@id", id);
            // Exécution de la requête
            command.ExecuteNonQuery();
        }

        //Modif d'une personne
        public static void Update(Personne personne)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            // Définition de la requête
            command.CommandText = "UPDATE FROM Personne (id,ref,nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche) VALUES (@id,@ref,@nom, @prenom, @login, @mdp, @adresse, @cp, @ville, @dateEmbauche)";
            command.Parameters.AddWithValue("@id", personne.Id);
            command.Parameters.AddWithValue("@ref", personne.Reference);
            command.Parameters.AddWithValue("@nom", personne.Nom);
            command.Parameters.AddWithValue("@prenom", personne.Prenom);
            command.Parameters.AddWithValue("@login", personne.Login);
            command.Parameters.AddWithValue("@mdp", personne.Mdp);
            command.Parameters.AddWithValue("@adresse", personne.Adresse);
            command.Parameters.AddWithValue("@cp", personne.Cp);
            command.Parameters.AddWithValue("@ville", personne.Ville);
            command.Parameters.AddWithValue("@dateEmbauche", personne.DateEmbauche);
            // Exécution de la requête
            command.ExecuteNonQuery();
        }

    }
}
