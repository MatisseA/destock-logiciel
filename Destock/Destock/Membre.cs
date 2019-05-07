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
    public partial class Membre : Form
    {
        FormPrincipale lien;
        public Membre(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        public List<Admin> CollAdmin;
        public String ChaineConnexion;
        public MySqlConnection GestConn;

        private void Membre_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
                //Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);
                CollAdmin = new List<Admin>();
                ChargementCollectionAdmin(doSql());

                DoRecherche();

            }
            catch (Exception ex) { MessageBox.Show("Erreur Load : " + ex.Message); }
        }

        public struct Admin
        {
            public int id;
            public String nom;
            public String prenom;
            public String mail;
            public String ville;
            public String adresse;
            public String cp;
            public String telephone;
            public String mdp;
            public String login;
            public String type;
            public String photo;
            public String desc;
            public int valide;
            public double argent;
        }

        private void ChargementCollectionAdmin(String requeteSQL)
        {
            try
            {
                CollAdmin.Clear();
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                MySqlCommand MaCommande = new MySqlCommand(requeteSQL, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderAdmin;
                //Exécution de la requête
                ReaderAdmin = MaCommande.ExecuteReader();
                //Nouveau contact
                Admin NouveauAdmin;

                while (ReaderAdmin.Read())
                {
                    NouveauAdmin.id = int.Parse(ReaderAdmin["ID_MEMBRE"].ToString());
                    NouveauAdmin.nom = (ReaderAdmin["NOM_MEMBRE"].ToString());
                    NouveauAdmin.prenom = (ReaderAdmin["PRENOM_MEMBRE"].ToString());
                    NouveauAdmin.mail = (ReaderAdmin["EMAIL_MEMBRE"].ToString());
                    NouveauAdmin.ville = (ReaderAdmin["VILLE_MEMBRE"].ToString());
                    NouveauAdmin.adresse = (ReaderAdmin["ADRESSE_MEMBRE"].ToString());
                    NouveauAdmin.cp = (ReaderAdmin["CP_MEMBRE"].ToString());
                    NouveauAdmin.telephone = (ReaderAdmin["TEL_MEMBRE"].ToString());
                    NouveauAdmin.mdp = (ReaderAdmin["MDP_MEMBRE"].ToString());
                    NouveauAdmin.login = (ReaderAdmin["LOGIN_MEMBRE"].ToString());
                    NouveauAdmin.type = (ReaderAdmin["TYPE_MEMBRE"].ToString());
                    NouveauAdmin.photo = (ReaderAdmin["PHOTO_MEMBRE"].ToString());
                    NouveauAdmin.desc = (ReaderAdmin["DESC_MEMBRE"].ToString());
                    NouveauAdmin.valide = int.Parse(ReaderAdmin["VALIDE_MEMBRE"].ToString());
                    NouveauAdmin.argent = Convert.ToDouble(ReaderAdmin["ARGENT_MEMBRE"].ToString());

                    CollAdmin.Add(NouveauAdmin);
                }

                ReaderAdmin.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        public String doSql()
        {
            String requete;

            requete = "SELECT * FROM membre WHERE ID_MEMBRE > 0";

            if (TextNom.Text != "")
            {
                requete = requete + " AND NOM_MEMBRE LIKE '%" + TextNom.Text + "%'";
            }
            if (TextBoxPrenom.Text != "")
            {
                requete = requete + " AND PRENOM_MEMBRE LIKE '%" + TextBoxPrenom.Text + "%'";
            }
            if (TextBoxEmail.Text != "")
            {
                requete = requete + " AND EMAIL_MEMBRE LIKE '%" + TextBoxEmail.Text + "%'";
            }
            

            requete = requete + " ORDER BY ID_MEMBRE";
            return requete;
        }

        public void DoRecherche()
        {
            int i = 0;
            foreach (Admin unAdmin in CollAdmin)
            {
                DataGridView1.Rows.Add(unAdmin.id.ToString(), unAdmin.nom.ToString(), unAdmin.prenom.ToString(), unAdmin.mail.ToString());
                i++;
            }
            TxtNbMembre.Text = i + " membres affichés";
        }

        private void BTN_Afficher(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            ChargementCollectionAdmin(doSql());
            DoRecherche();
        }

        private void changeActiviteDetail(object sender, DataGridViewCellEventArgs e)
        {
            DétailsMembres Mafenetre = new DétailsMembres(DataGridView1.CurrentRow.Cells[0].Value.ToString(), this.lien);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this.lien;
            Mafenetre.Show();
        }
    }
}
