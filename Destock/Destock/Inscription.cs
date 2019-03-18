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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        public List<Admin> CollAdmin;
        public String ChaineConnexion;
        public MySqlConnection GestConn;

        private void Inscription_Load(object sender, EventArgs e)
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

        private bool Verif()
        {
            bool rep = true;

            if ((TBNom.Text == "") || ((TBNom.Text).Count() > 255))
                rep = false;
            if ((TBPrenom.Text == "") || ((TBPrenom.Text).Count() > 255))
                rep = false;
            if ((TBLogin.Text == "") || ((TBLogin.Text).Count() > 255))
                rep = false;
            if ((TBMDP.Text == "") || ((TBMDP.Text).Count() > 255))
                rep = false;
            if ((TBMail.Text == "") || ((TBMail.Text).Count() > 100))
                rep = false;
            if ((TBVille.Text == "") || ((TBVille.Text).Count() > 255))
                rep = false;
            if ((TBAdresse.Text == "") || ((TBAdresse.Text).Count() > 255))
                rep = false;
            if ((TBCP.Text == "") || ((TBCP.Text).Count() > 6))
                rep = false;
            if (TBTel.Text == "")
                rep = false;

            return rep;
        }

        private void BtnValiderInscription_Click(object sender, EventArgs e)
        {
            if (Verif())
            {
                try
                {
                    //Ouverture connexion
                    GestConn.Open();
                    //Requete SQL
                    String ReqSql = "INSERT INTO membre(NOM_MEMBRE,PRENOM_MEMBRE,EMAIL_MEMBRE,VILLE_MEMBRE,ADRESSE_MEMBRE,CP_MEMBRE,TEL_MEMBRE,MDP_MEMBRE,LOGIN_MEMBRE,TYPE_MEMBRE,PHOTO_MEMBRE,DESC_MEMBRE,VALIDE_MEMBRE,ARGENT_MEMBRE) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
                    MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                    //Création des paramètres correspondant aux "?"
                    MySqlParameter Param1 = MaCommande.Parameters.Add("@NOM_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param2 = MaCommande.Parameters.Add("@PRENOM_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param3 = MaCommande.Parameters.Add("@EMAIL_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param4 = MaCommande.Parameters.Add("@VILLE_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param5 = MaCommande.Parameters.Add("@ADRESSE_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param6 = MaCommande.Parameters.Add("@CP_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param7 = MaCommande.Parameters.Add("@TEL_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param8 = MaCommande.Parameters.Add("@MDP_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param9 = MaCommande.Parameters.Add("@LOGIN_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param10 = MaCommande.Parameters.Add("@TYPE_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param11 = MaCommande.Parameters.Add("@PHOTO_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param12 = MaCommande.Parameters.Add("@DESC_MEMBRE", MySqlDbType.VarChar);
                    MySqlParameter Param13 = MaCommande.Parameters.Add("@VALIDE_MEMBRE", MySqlDbType.Int16);
                    MySqlParameter Param14 = MaCommande.Parameters.Add("@ARGENT_MEMBRE", MySqlDbType.Int16);
                    //Affectation des valeurs depuis des TextBox
                    Admin unAdmin = ConstruireAdmin();

                    Param1.Value = unAdmin.nom;
                    Param2.Value = unAdmin.prenom;
                    Param3.Value = unAdmin.mail;
                    Param4.Value = unAdmin.ville;
                    Param5.Value = unAdmin.adresse;
                    Param6.Value = unAdmin.cp;
                    Param7.Value = unAdmin.telephone;
                    Param8.Value = unAdmin.mdp;
                    Param9.Value = unAdmin.login;
                    Param10.Value = unAdmin.type;
                    Param11.Value = unAdmin.photo;
                    Param12.Value = unAdmin.desc;
                    Param13.Value = unAdmin.valide;
                    Param14.Value = unAdmin.argent;

                    //Exécution de la requête
                    MaCommande.ExecuteNonQuery();
                    //Fermeture de la connexion
                    GestConn.Close();
                    ChargementCollectionAdmin();

                    this.Close();

                    MessageBox.Show("Inscription validée");

                }
                catch (Exception ex)
                {
                    GestConn.Close();
                    MessageBox.Show("Erreur Bouton : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Certaines zones ne sont pas renseignées", "Erreur");
            }
        }
        private Admin ConstruireAdmin()
        {
            Admin NvContact = new Admin();

            NvContact.id = 0;
            NvContact.nom = TBNom.Text;
            NvContact.prenom = TBPrenom.Text;
            NvContact.mail = TBMail.Text;
            NvContact.ville = TBVille.Text;
            NvContact.adresse = TBAdresse.Text;
            NvContact.cp = TBCP.Text;
            NvContact.telephone = TBTel.Text;
            NvContact.mdp = GetMD5(TBMDP.Text);
            NvContact.login = TBLogin.Text;
            NvContact.type = "ADMINISTRATEUR";
            NvContact.photo = "null";
            NvContact.desc = "";
            NvContact.valide = 1;
            NvContact.argent = 0;

            return NvContact;
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
