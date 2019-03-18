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
using System.Security.Cryptography;

namespace Destock
{
    public partial class Connexion : Form
    {
        FormPrincipale lien;
        public Connexion(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        public List<Admin> CollAdmin;
        public String ChaineConnexion;
        public MySqlConnection GestConn;

        private void Connexion_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=127.0.0.1;port=3306;user=root;database=2017-destock_bdd;encrypt=false";
                //Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);
                CollAdmin = new List<Admin>();
                ChargementCollectionAdmin();
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

        private void ChargementCollectionAdmin()
        {
            try
            {
                CollAdmin.Clear();
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM membre ORDER BY ID_MEMBRE";
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
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

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            String pseudo = TBLogin.Text;
            String mtdp = GetMD5(TBMDP.Text);
            String letype = "ADMINISTRATEUR";
            bool verif = false;
            int i = 0;

            while ((i < CollAdmin.Count()) && (verif == false))
            {
                if ((CollAdmin[i].login == pseudo) && (CollAdmin[i].mdp == mtdp) && (CollAdmin[i].type == letype))
                {
                    lien.TSMConn.Enabled = false;
                    lien.TSMDeco.Enabled = true;
                    lien.TSStext.Text = "Vous êtes connecté en tant que " + CollAdmin[i].nom + " " + CollAdmin[i].prenom;
                    this.Close();
                    MessageBox.Show("Vous êtes connecté");
                    verif = true;
                }
                i++;
            }

            if (verif == false)
            {
                MessageBox.Show("Votre login ou votre mot de passe est incorrect");
            }
        }

        public string GetMD5(string text)
        {
            byte[] raw = UTF8Encoding.UTF8.GetBytes(text);

            byte[] hash;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = md5Hash.ComputeHash(raw);
            }

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sBuilder.Append(hash[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
