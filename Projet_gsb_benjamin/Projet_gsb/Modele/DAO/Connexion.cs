﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows;
using System.Data;

namespace Projet_gsb_Cath_Ben_Franck_Glad.Modele.DAO
{
    class Connexion
    {
        //On initialise la connexion à null
        public static SqlConnection LaConnexion { get; set; } = null;
        private static string Login { get; set; } = null;
        private static string MDP { get; set; } = null;

        public static void InitialiserConnexion(string login, string mdp)
        {
            Login = login;
            MDP = mdp;
        }

        public static void DeconnecterUtilisateur()
        {
            Login = null;
            MDP = null;
        }

        public static void close()
        {
            LaConnexion.Close();
            LaConnexion = null;
        }

        public static SqlConnection GetInstance()
        {
            if (Login != null)
            {

                // Préparation de la connexion à la base de données
                if (LaConnexion == null)
                { 

                    // connection Amelie
                    
                   /* string serveur = "Data Source=ADMIN-PC\\SQLSERVERPERSO;";
                    string bd = "Initial Catalog=gsb;";
                    string login = "User Id=amelie;";
                    string mdp = "Password=sio;";
                    string connectionString = serveur + bd + login + mdp;*/
                
                    // connection Franck
                    /*
                    string serveur = "Data Source=BTSWIN7-99\\MSSERVERPERSO;";
                    string bd = "Initial Catalog=gsb;";
                    string login = "User Id=franck;";
                    string mdp = "Password=sio;";
                    string connectionString = serveur + bd + login + mdp;*/

                    // connection Ben 
                    string serveur = "Data Source=DESKTOP-UJTLU9S\\SQLEXPRESS;";
                    string bd = "Initial Catalog=gsb;Integrated Security=True;";
                    //string login = "User Id=benjamin;";
                    //string mdp = "Password=sio0402;";
                    //string connectionString = serveur + bd + login + mdp;
                    string connectionString = serveur + bd;

                    LaConnexion = new SqlConnection(connectionString);
                    try
                    {
                        // Connexion à la base de données
                        LaConnexion.Open();
                        
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Accès Base de Donnée refusé");
                    }
                }
            }
            return LaConnexion;


        }
        // TODO Reste la déconnexion 

        //Constructeur vide, ainsi, modèle singleton : on ne peut se connecter que par meth GetInstance()
        private Connexion() { }
    }
}