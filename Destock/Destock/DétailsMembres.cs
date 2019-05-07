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
    public partial class DétailsMembres : Form
    {
        String idMembre;
        String nom;
        String prenom;
        String mail;
        String ville;
        String adresse;
        String cp;
        String telephone;
        String mdp;
        String login;
        String type;
        String photo;
        String desc;
        int valide;
        double argent;

        public String ChaineConnexion;
        public MySqlConnection GestConn;
        public DataView dv;

        FormPrincipale lien;

        public DétailsMembres(String idMembre, FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
            this.idMembre = idMembre;
        }

        private void DétailsMembres_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
                // Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);

                rechercheInformation("SELECT * FROM membre WHERE ID_MEMBRE=" + this.idMembre);
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
                MySqlDataReader ReaderAdmin;
                //Exécution de la requête
                ReaderAdmin = MaCommande.ExecuteReader();

                while (ReaderAdmin.Read())
                {
                    
                    this.nom = (ReaderAdmin["NOM_MEMBRE"].ToString());
                    this.prenom = (ReaderAdmin["PRENOM_MEMBRE"].ToString());
                    this.mail = (ReaderAdmin["EMAIL_MEMBRE"].ToString());
                    this.ville = (ReaderAdmin["VILLE_MEMBRE"].ToString());
                    this.adresse = (ReaderAdmin["ADRESSE_MEMBRE"].ToString());
                    this.cp = (ReaderAdmin["CP_MEMBRE"].ToString());
                    this.telephone = (ReaderAdmin["TEL_MEMBRE"].ToString());
                    this.mdp = (ReaderAdmin["MDP_MEMBRE"].ToString());
                    this.login = (ReaderAdmin["LOGIN_MEMBRE"].ToString());
                    this.type = (ReaderAdmin["TYPE_MEMBRE"].ToString());
                    this.photo = (ReaderAdmin["PHOTO_MEMBRE"].ToString());
                    this.desc = (ReaderAdmin["DESC_MEMBRE"].ToString());
                    this.valide = int.Parse(ReaderAdmin["VALIDE_MEMBRE"].ToString());
                    this.argent = Convert.ToDouble(ReaderAdmin["ARGENT_MEMBRE"].ToString());

                }
                ReaderAdmin.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void changeInformation()
        {
            this.Text = this.Text + " - " + this.prenom + " " + this.nom;
            TxtPrenom.Text = this.prenom + " " + this.nom;
            Txtid.Text = "id : " + this.idMembre;
            TxtEmail.Text = "EMail : " + this.mail;
            TxtVille.Text = "Ville : " + this.ville;
            TxtAdresse.Text = "Adresse : " + this.adresse;
            TxtCP.Text = "Code Postal : " + this.cp;
            TxtTel.Text = "Téléphone : " + this.telephone;
            TxtType.Text = "Type : " + this.type;
            if (this.valide != 0)
            { TxtValide.Text =  "Validé : Oui";
                BtnValide.Visible = false;
            }
            else
            { TxtValide.Text = "Validé : Non"; }

            TxtArgent.Text = "Argent : " + this.argent.ToString();
            TxtDesc.Text = this.desc;

            if (this.photo != "null")
            {
                pictureBox1.Load("http://btsinfo-rousseau53.fr:11017/2017-destock/Public/Images_Profil/" + this.photo);
            }
            else
            {
                TxtImage.Visible = true;
            }
      
        }

        private void linkLabel_redirection_site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://btsinfo-rousseau53.fr:11017/2017-destock/index.php?c=profilutil&u=" + this.idMembre);
        }

        private void BtnValide_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "UPDATE membre SET VALIDE_MEMBRE = '1' WHERE ID_MEMBRE=" + this.idMembre;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderMembre;
                //Exécution de la requête
                ReaderMembre = MaCommande.ExecuteReader();
                ReaderMembre.Close();
                GestConn.Close();
                MessageBox.Show("Ce membre est maintenant validé.");
                this.valide = 1;
                changeInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "DELETE FROM membre WHERE ID_MEMBRE=" + this.idMembre;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderMembre;
                //Exécution de la requête
                ReaderMembre = MaCommande.ExecuteReader();
                ReaderMembre.Close();
                GestConn.Close();
                MessageBox.Show("Ce compte est maintenant supprimé.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
