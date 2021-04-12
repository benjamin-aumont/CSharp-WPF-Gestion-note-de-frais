using GestionFrais;
using Projet_gsb;
using Projet_gsb_Cath_Ben_Franck_Glad.Modele.DAO;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows;


namespace Projet_gsb_Cath_Ben_Franck_Glad
{
    /// <summary>
    /// Logique d'interaction pour Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private int IdFiche;
        private int IdVisiteur;

        public Window4()
        {
            InitializeComponent();
        }

        public Window4(int idFiche, int idVisiteur) : this()
        {
            this.IdFiche = idFiche;
            this.IdVisiteur = idVisiteur;
        }




        private void valider_Click(object sender, RoutedEventArgs e)
        {
            string date = Date.Text;
            int montantV = int.Parse(montant.Text, CultureInfo.InvariantCulture.NumberFormat);
            //   int idVisiteurV = int.Parse(idVisiteur.Text, CultureInfo.InvariantCulture.NumberFormat);
            int repasV = int.Parse(repas.Text, CultureInfo.InvariantCulture.NumberFormat);
            int nuiteeV = int.Parse(nuitee.Text, CultureInfo.InvariantCulture.NumberFormat);
            int kmV = int.Parse(kmetre.Text, CultureInfo.InvariantCulture.NumberFormat);
            int montantTotal = repasV + nuiteeV + kmV + montantV;

            FicheDeFrais ficheFraisModifiee = new FicheDeFrais(date, montantV, 1, IdVisiteur, nuiteeV, kmV, repasV, montantTotal);
            DAOFicheFrais.Update(IdFiche, ficheFraisModifiee);
            Window2 window2 = new Window2(IdVisiteur);
            window2.Show();
            this.Hide();
        }

        private void montant_Loaded(object sender, RoutedEventArgs e)
        {

            //Requete sql pour récup id, nom, prenom de la personne connectée
            SqlCommand command = new SqlCommand("SELECT montantValide FROM FicheFrais WHERE id='" + IdFiche + "' ", Connexion.LaConnexion);
            SqlDataReader reader = command.ExecuteReader();
            //Lecture des résultats
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            montant.Text = result.ToString();

        }

        private void kmetre_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT km FROM FicheFrais WHERE id='" + IdFiche + "' ", Connexion.LaConnexion);
            SqlDataReader reader = command.ExecuteReader();
            //Lecture des résultats
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            kmetre.Text = result.ToString();
        }

        private void repas_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT repas FROM FicheFrais WHERE id='" + IdFiche + "' ", Connexion.LaConnexion);
            SqlDataReader reader = command.ExecuteReader();
            //Lecture des résultats
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            repas.Text = result.ToString();
        }

        private void nuitee_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT nuitee FROM FicheFrais WHERE id='" + IdFiche + "' ", Connexion.LaConnexion);
            SqlDataReader reader = command.ExecuteReader();
            //Lecture des résultats
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            //nuitee.text est le textBox de la nuitee
            nuitee.Text = result.ToString();

        }

        private void Date_Loaded(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT mois FROM FicheFrais WHERE id='" + IdFiche + "' ", Connexion.LaConnexion);
            SqlDataReader reader = command.ExecuteReader();
            //Lecture des résultats
            reader.Read();
            string result = reader.GetString(0);
            reader.Close();
            Date.Text = result;
        }
    }
}