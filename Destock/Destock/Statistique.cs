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
        public String legend3;
        public String titreGraphique;

        public List<double> listInt;

        private void Statistique_Load(object sender, EventArgs e)
        {
            connexionBDD();
            legend1 = "Series1";
            legend2 = "Series2";
            legend3 = "Series3";
            reinitialiserValeur();
            comboBox_choix.DropDownStyle = ComboBoxStyle.DropDownList;
            listInt = new List<double>();
        }

        private void reinitialiserValeur()
        {
            graphique.Series[legend1].Name = "Series1";
            graphique.Series[legend2].Name = "Series2";
            graphique.Series[legend3].Name = "Series3";

            legend1 = "Series1";
            legend2 = "Series2";
            legend3 = "Series3";
            titreGraphique = "Titre";

            changeEnabledSeries(false, false, false);
            

            graphique.Series[legend1].Points.Clear();
            graphique.Series[legend2].Points.Clear();
            graphique.Series[legend3].Points.Clear();
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
            setNameSeries();
            changeChartType("starkedbar100");
            changeEnabledSeries(true, true, false);

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("%", nbPremium);
            graphique.Series[legend2].Points.AddXY("%", nbTotal-nbPremium);
        }

        //Affiche le nombre total d'annonce en ligne
        private void statNbTotalAnnonce()
        {
            int nbTotal = count("annonce", "");
            int nbAnnonceDeleted = count("annonce", "STATUT_ANNC = 'deleted'");

            legend1 = "Nombre total d'annonce";
            legend2 = "Annonces en lignes";
            legend3 = "Annonces supprimées";
            titreGraphique = "Nombre total d'annonce";

            //Set les nouveaux noms
            setNameSeries();


            changeEnabledSeries(true, true, true);
            changeChartType("column");

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("Annonce", nbTotal);
            graphique.Series[legend2].Points.AddXY("Annonce", nbTotal-nbAnnonceDeleted);
            graphique.Series[legend3].Points.AddXY("Annonce", nbAnnonceDeleted);
        }

        private void statMembreAdmin()
        {
            int nbAdmin = count("membre", "TYPE_MEMBRE = 'ADMINISTRATEUR'");
            int nbTotal = count("membre", "TYPE_MEMBRE = 'UTILISATEUR'");

            legend1 = "Membre";
            titreGraphique = "Poucentage de membre administrateur";

            //Set les nouveaux noms
            setNameSeries();


            changeEnabledSeries(true, false, false);
            changeChartType("pie");

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("Utilisateur - ("+nbTotal+")", nbTotal);
            graphique.Series[legend1].Points.AddXY("Administrateur - (" + nbAdmin + ")", nbAdmin);
        }

        private void statMembreValide()
        {
            int nbValide = count("membre", "VALIDE_MEMBRE = 1");
            int nbTotal = count("membre", "VALIDE_MEMBRE = 0");

            legend1 = "Membre";
            titreGraphique = "Poucentage de membre validé";

            //Set les nouveaux noms
            setNameSeries();


            changeEnabledSeries(true, false, false);
            changeChartType("pie");

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("Utilisateur - (" + nbTotal + ")", nbTotal);
            graphique.Series[legend1].Points.AddXY("Validé - (" + nbValide + ")", nbValide);
        }

        private void statArgentDestock()
        {
            chargeList("virement", "", "MONTANT_VIR");

            legend1 = "Un virement";
            legend2 = "Total argent gagné";
            titreGraphique = "Argent gagné";

            setNameSeries();

            changeEnabledSeries(true, true, false);
            changeChartType("stackedarea");
            
            double totalMontant = 0;
            //Change les données du tableau de stats
            foreach (double lemontant in listInt)
            {
                totalMontant = totalMontant + lemontant;
                graphique.Series[legend1].Points.AddXY("", lemontant);
                graphique.Series[legend2].Points.AddXY("", totalMontant);
            }
        }

        private void statNbCommentaireCommandePlainte()
        {
            int nbCommentaire = count("commentaire", "");
            int nbCommande = count("commande", "");
            int nbPlainte = count("plainte", "");

            legend1 = "Commentaire";
            legend2 = "Commande";
            legend3 = "Plainte";
            titreGraphique = "Nombre de commentaire, commande et plainte";

            //Set les nouveaux noms
            setNameSeries();


            changeEnabledSeries(true, true, true);
            changeChartType("column");

            //Change les données du tableau de stats
            graphique.Series[legend1].Points.AddXY("", nbCommentaire);
            graphique.Series[legend2].Points.AddXY("", nbCommande);
            graphique.Series[legend3].Points.AddXY("", nbPlainte);
        }

        private void statNotesCommentaires()
        {
            chargeList("commentaire", "", "NOTE_COMM");

            legend1 = "Note";
            titreGraphique = "Notes associés aux commentaires";

            setNameSeries();

            changeEnabledSeries(true, false, false);
            changeChartType("radar");

            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int total5 = 0;
            //Change les données du tableau de stats
            foreach (int lemontant in listInt)
            {
                switch (lemontant)
                {
                    case 1:
                        total1++;
                        break;
                    case 2:
                        total2++;
                        break;
                    case 3:
                        total3++;
                        break;
                    case 4:
                        total4++;
                        break;
                    case 5:
                        total5++;
                        break;
                } 
            }
            graphique.Series[legend1].Points.AddXY("1", total1);
            graphique.Series[legend1].Points.AddXY("2", total2);
            graphique.Series[legend1].Points.AddXY("3", total3);
            graphique.Series[legend1].Points.AddXY("4", total4);
            graphique.Series[legend1].Points.AddXY("5", total5);

        }

        //Permet de changer l'etats des Series
        private void changeEnabledSeries(bool series1, bool series2, bool series3)
        {
            graphique.Series[legend1].Enabled = series1;
            graphique.Series[legend2].Enabled = series2;
            graphique.Series[legend3].Enabled = series3;
        }

        //Connexion à la base de données
        private void connexionBDD()
        {
            // Chaîne de connexion à la base
            ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
            //Création de la connexion
            GestConn = new MySqlConnection(ChaineConnexion);
        }

        //Compte les éléments, sous certaines conditlions
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

        public void chargeList(String from, String where, String what)
        {
            listInt.Clear();
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
                    listInt.Add(double.Parse(ReaderCalcul[what].ToString()));
                }
                ReaderCalcul.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        //Permet de mettre le graphique de la façon souhaité
        public void changeChartType(String disposition)
        {
            switch (disposition)
            {
                case "column":
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case "starkedbar100":
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
                    break;
                case "pie":
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    break;
                case "line":
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case "stackedarea":
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
                    break;
                case "radar":
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
                    break;
                default:
                    graphique.Series[legend1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    graphique.Series[legend2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    graphique.Series[legend3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
            }
        }

        //Actualise les nom Series
        private void setNameSeries()
        {
            graphique.Series["Series1"].Name = legend1;
            graphique.Series["Series2"].Name = legend2;
            graphique.Series["Series3"].Name = legend3;
            graphique.Titles["titre_graphique"].Text = titreGraphique;
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
                case "Annonces en lignes/supprimées":
                    statNbTotalAnnonce();
                    break;
                case "Pourcentage de membre administrateur":
                    statMembreAdmin();
                    break;
                case "Pourcentage de membre validé":
                    statMembreValide();
                    break;
                case "Argent gagné par l'entreprise":
                    statArgentDestock();
                    break;
                case "Nombre de commentaire, commande, plainte":
                    statNbCommentaireCommandePlainte();
                    break;
                case "Notes associées aux commentaires":
                    statNotesCommentaires();
                    break;
                default:
                    MessageBox.Show("Erreur lors du chargement du graphique.");
                    break;
            }
        }
    }
}
