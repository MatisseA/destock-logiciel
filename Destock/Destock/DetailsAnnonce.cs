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
    public partial class DetailsAnnonce : Form
    {
        String idAnnonce;
        int id_membre;
        String titre;
        String description;
        String image;
        double prix_depart;
        double prix_actuelle;
        int quantite;
        String date;
        String type;
        String statut;
        String unite;

        public String ChaineConnexion;
        public MySqlConnection GestConn;
        public DataView dv;

        FormPrincipale lien;

        public DetailsAnnonce(String idAnnonce, FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
            this.idAnnonce = idAnnonce;
        }

        private void DetailsAnnonce_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
                //Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);

                rechercheInformation("SELECT * FROM annonce WHERE ID_ANNC="+ this.idAnnonce);
                changeInformation();

            }
            catch (Exception ex) { MessageBox.Show("Erreur Load : " + ex.Message); }
        }

        public void rechercheInformation(String requeteSQL)
        {
            try
            {
                //Ouverture connexion
                GestConn.Open();
                MySqlCommand MaCommande = new MySqlCommand(requeteSQL, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderAnnonce;
                //Exécution de la requête
                ReaderAnnonce = MaCommande.ExecuteReader();
                
                while (ReaderAnnonce.Read())
                {
                    this.id_membre = int.Parse(ReaderAnnonce["ID_MEMBRE"].ToString());
                    this.titre = (ReaderAnnonce["TITRE_ANNC"].ToString());
                    this.description = (ReaderAnnonce["DESC_ANNC"].ToString());
                    this.image = (ReaderAnnonce["IMAGE_ANNC"].ToString());
                    this.prix_depart = Convert.ToDouble(ReaderAnnonce["PRIXDEP_ANNC"].ToString());
                    this.prix_actuelle = Convert.ToDouble(ReaderAnnonce["PRIXACT_ANNC"].ToString());
                    this.quantite = int.Parse(ReaderAnnonce["QTE_ANNC"].ToString());
                    this.date = (ReaderAnnonce["DATE_ANNC"].ToString());
                    this.type = (ReaderAnnonce["TYPE_ANNC"].ToString());
                    this.statut = (ReaderAnnonce["STATUT_ANNC"].ToString());
                    this.unite = (ReaderAnnonce["UNITE_ANNC"].ToString());
                    
                }
                ReaderAnnonce.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        //Permet d'optenir le nom et le prenom du vendeur
        public String changeNameUserbyId(String idUser)
        {
            String nomEntier = idUser;
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM membre WHERE ID_MEMBRE=" + idUser;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderMembre;
                //Exécution de la requête
                ReaderMembre = MaCommande.ExecuteReader();
                while (ReaderMembre.Read())
                {
                    nomEntier = (ReaderMembre["NOM_MEMBRE"].ToString()) + " " + (ReaderMembre["PRENOM_MEMBRE"].ToString());
                }
                ReaderMembre.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            return nomEntier;
        }

        //Permet de changer tout les textes avec les nouvelles informations
        private void changeInformation()
        {
            this.Text = this.Text + " - " + this.titre;
            label_txt_id_annonce.Text = this.idAnnonce;
            label_txt_titre.Text = this.titre;
            label_txt_prix_depart.Text = this.prix_depart.ToString() + "€";
            label_txt_prix_actuel.Text = this.prix_actuelle.ToString() + "€";
            label_txt_date.Text = this.date;
            
            if(this.type != "premium")
            {
                button_premium.Visible = true;
            }
            if(this.description != "")
            {
                label_txt_description.Text = this.description;
            }
            else
            {
                label_txt_description.Text = "Pas de description pour cette annonce.";
            }
            label_txt_auteur.Text = changeNameUserbyId(this.id_membre.ToString());
            if (this.image != "")
            {
                pictureBox_image.Load("http://btsinfo-rousseau53.fr:11017/2017-destock/Public/Images_Annonces/" + this.image);
            }
            else
            {
                label_no_image.Visible = true;
            }
        }

        private void linkLabel_redirection_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Permet d'ouvrir le navigateur et d'aller directement sur le lien concernant l'annonce visionnée
            System.Diagnostics.Process.Start("http://btsinfo-rousseau53.fr:11017/2017-destock/index.php?c=voirannonce&a="+ this.idAnnonce);
        }

        private void button_premium_Click(object sender, EventArgs e)
        {
            //Met l'annonce en statut premium (couleur jaune à l'affichage)
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "UPDATE annonce SET TYPE_ANNC = 'premium' WHERE ID_ANNC=" + this.idAnnonce;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderMembre;
                //Exécution de la requête
                ReaderMembre = MaCommande.ExecuteReader();
                ReaderMembre.Close();
                GestConn.Close();
                MessageBox.Show("L'annonce est maintenant en premium.");
                button_premium.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            //Met l'annonce en statut premium (couleur jaune à l'affichage)
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "UPDATE annonce SET STATUT_ANNC = 'deleted' WHERE ID_ANNC=" + this.idAnnonce;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderMembre;
                //Exécution de la requête
                ReaderMembre = MaCommande.ExecuteReader();
                ReaderMembre.Close();
                GestConn.Close();
                MessageBox.Show("L'annonce est maintenant supprimée.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
