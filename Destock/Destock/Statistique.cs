using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destock
{
    public partial class Statistique : Form
    {
        FormPrincipale lien;
        public Statistique(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }
        public String ChaineConnexion;
        public MySqlConnection GestConn;

        public String legend1;
        public String legend2;
        public String titreGraphique;

        private void Statistique_Load(object sender, EventArgs e)
        {
            connexionBDD();
            statPremiumPourcentage();
            comboBox_choix.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void reinitialiserValeur()
        {
            graphique.Series[legend1].Name = "Series1";
            graphique.Series[legend2].Name = "Series2";

            legend1 = "Series1";
            legend2 = "Series2";
            titreGraphique = "Titre";

            changeEnabledSeries(false, false);

            graphique.Series[legend1].Points.AddXY("", 0);
            graphique.Series[legend2].Points.AddXY("", 0);
            graphique.Titles["titre_graphique"].Text = titreGraphique;
        }

        private void statPremiumPourcentage()
        {
            int nbTotal = count("annonce","");
            int nbPremium = count("annonce", "TYPE_ANNC='premium'");

            legend1 = "Annonce premium";
            legend2 = "Annonce non premium";
            titreGraphique = "Pourcentage d'annonces premium";

            //Set les nouveaux noms
            graphique.Series["Series1"].Name = legend1;
            graphique.Series["Series2"].Name = legend2;

            changeEnabledSeries(true, true);

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("%", nbPremium);
            graphique.Series[legend2].Points.AddXY("%", nbTotal-nbPremium);

            //Set le titre
            graphique.Titles["titre_graphique"].Text = titreGraphique;
        }

        private void statNbTotalAnnonce()
        {
            int nbTotal = count("annonce", "");

            legend1 = "Annonce premium";
            titreGraphique = "Nombre total d'annonce en ligne";

            //Set les nouveaux noms
            graphique.Series["Series1"].Name = legend1;
            changeEnabledSeries(true, false);

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("Annonce", nbTotal);

            //Set le titre
            graphique.Titles["titre_graphique"].Text = titreGraphique;
        }

        private void changeEnabledSeries(bool series1, bool series2)
        {
            graphique.Series[legend1].Enabled = series1;
            graphique.Series[legend2].Enabled = series2;
        }

        private void connexionBDD()
        {
            // Chaîne de connexion à la base
            ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
            //Création de la connexion
            GestConn = new MySqlConnection(ChaineConnexion);
        }

        public int count(String from, String where)
        {
            int total = 0;
            String requete = "SELECT * FROM " + from;
            if(where != "")
            {
                requete = requete + " WHERE " + where;
            }
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                MySqlCommand MaCommande = new MySqlCommand(requete, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderCalcul;
                //Exécution de la requête
                ReaderCalcul = MaCommande.ExecuteReader();
                while (ReaderCalcul.Read())
                {
                    total++;
                }
                ReaderCalcul.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            return total;
        }

        private void button_générer_Click(object sender, EventArgs e)
        {
            connexionBDD();
            reinitialiserValeur();
            switch (comboBox_choix.Text)
            {
                case "Pourcentage d'annonces premium":
                    statPremiumPourcentage();
                    break;
                case "Nombre total d'annonce en ligne":

                    break;
                default:
                    MessageBox.Show("Erreur lors du chargement du graphique.");
                    break;
            }
        }
    }
}
