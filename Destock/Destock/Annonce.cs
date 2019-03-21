using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Destock
{
    public partial class Annonce : Form
    {
        FormPrincipale lien;
        public Annonce(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        public List<uneAnnonce> CollAnnonce;
        public String ChaineConnexion;
        public MySqlConnection GestConn;
        public DataView dv;

        private void Annonce_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
                //Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);
                CollAnnonce = new List<uneAnnonce>();
                ChargementCollectionAdmin();

                int i = 0;
                foreach (uneAnnonce laAnnonce in CollAnnonce)
                {
                    dataGridViewAnnonce.Rows.Add(laAnnonce.id_annonce.ToString());
                    i++;
                }
                //TxtNbMembre.Text = i + " membres affichés";

            }
            catch (Exception ex) { MessageBox.Show("Erreur Load : " + ex.Message); }
        }

        //Construction de la structure Annonce
        public struct uneAnnonce
        {
            public int id_annonce;
            public int id_membre;
            public String titre;
            public String description;
            public String image;
            public double prix_depart;
            public double prix_actuelle;
            public int quantite;
            public String date;
            public String type;
            public String statut;
            public String unite;
        }

        //Permet de récuperer les informations des Annonces
        private void ChargementCollectionAdmin()
        {
            try
            {
                CollAnnonce.Clear();
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM annonce ORDER BY ID_ANNC";
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderAnnonce;
                //Exécution de la requête
                ReaderAnnonce = MaCommande.ExecuteReader();
                //Nouveau contact
                uneAnnonce NouvelAnnonce;

                while (ReaderAnnonce.Read())
                {
                    NouvelAnnonce.id_annonce =      int.Parse(ReaderAnnonce["ID_ANNC"].ToString());
                    NouvelAnnonce.id_membre =       int.Parse(ReaderAnnonce["ID_MEMBRE"].ToString());
                    NouvelAnnonce.titre =           (ReaderAnnonce["TITRE_ANNC"].ToString());
                    NouvelAnnonce.description =     (ReaderAnnonce["DESC_ANNC"].ToString());
                    NouvelAnnonce.image =           (ReaderAnnonce["IMAGE_ANNC"].ToString());
                    NouvelAnnonce.prix_depart =     Convert.ToDouble(ReaderAnnonce["PRIXDEP_ANNC"].ToString());
                    NouvelAnnonce.prix_actuelle =   Convert.ToDouble(ReaderAnnonce["PRIXACT_ANNC"].ToString());
                    NouvelAnnonce.quantite =        int.Parse(ReaderAnnonce["QTE_ANNC"].ToString());
                    NouvelAnnonce.date =            (ReaderAnnonce["DATE_ANNC"].ToString());
                    NouvelAnnonce.type =            (ReaderAnnonce["TYPE_ANNC"].ToString());
                    NouvelAnnonce.statut =          (ReaderAnnonce["STATUT_ANNC"].ToString());
                    NouvelAnnonce.unite =           (ReaderAnnonce["UNITE_ANNC"].ToString());

                    CollAnnonce.Add(NouvelAnnonce);
                }

                ReaderAnnonce.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
