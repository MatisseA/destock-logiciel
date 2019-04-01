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
    public partial class Commentaire : Form
    {
        FormPrincipale lien;
        public Commentaire(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        public List<unCommentaire> CollCommentaire;
        public List<unBadWord> CollBasWord;
        public String ChaineConnexion;
        public MySqlConnection GestConn;
        public DataView dv;

        private void Commentaire_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
                //Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);
                CollCommentaire = new List<unCommentaire>();
                addListAnnonce(doSql());
                doRecherche();
                addDernierCommentaire();
            }
            catch (Exception ex) { MessageBox.Show("Erreur Load : " + ex.Message); }
        }

        //Construction de la structure Commentaire
        public struct unCommentaire
        {
            public int id_comm;
            public int id_membre;
            public int id_vendeur_com;
            public String txt_comm;
            public String date_com;
            public int note_comm;
        }

        //Construction de la structure Commentaire
        public struct unBadWord
        {
            public String word;
        }

        private String doSql()
        {
            String requete = "SELECT * FROM commentaire ORDER BY ID_COMM";
            if (textBox_recherche.Text != "" && textBox_recherche.Text.Length >= 3){
                requete = "SELECT * FROM commentaire WHERE TXT_COMM LIKE '%"+ textBox_recherche.Text +"%'";
            }
            return requete;
        }

        public void addDernierCommentaire()
        {
            label_commentaire.Text = dataGridViewCommenaire.CurrentRow.Cells[4].Value.ToString();
        }

        private void doRecherche()
        {
            foreach (unCommentaire leCommentaire in CollCommentaire)
            {
                    String auteur = changeNameUserbyId(leCommentaire.id_membre.ToString());
                    String profilde = changeNameUserbyId(leCommentaire.id_vendeur_com.ToString());
                    dataGridViewCommenaire.Rows.Add(leCommentaire.id_comm.ToString(), auteur, profilde, leCommentaire.note_comm.ToString(), leCommentaire.txt_comm, leCommentaire.date_com.ToString());
            }
        }

        public void addListAnnonce(String requeteSQL)
        {
            try
            {
                CollCommentaire.Clear();
                //Ouverture connexion
                GestConn.Open();
                MySqlCommand MaCommande = new MySqlCommand(requeteSQL, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderAnnonce;
                //Exécution de la requête
                ReaderAnnonce = MaCommande.ExecuteReader();
                //Nouveau contact
                unCommentaire NouveauCommentaire;
                
                while (ReaderAnnonce.Read())
                {
                    NouveauCommentaire.id_comm = int.Parse(ReaderAnnonce["ID_COMM"].ToString());
                    NouveauCommentaire.id_membre = int.Parse(ReaderAnnonce["ID_MEMBRE"].ToString());
                    NouveauCommentaire.id_vendeur_com = int.Parse(ReaderAnnonce["ID_VENDEUR_COM"].ToString());
                    NouveauCommentaire.txt_comm = (ReaderAnnonce["TXT_COMM"].ToString());
                    NouveauCommentaire.date_com = (ReaderAnnonce["DATE_COMM"].ToString());
                    NouveauCommentaire.note_comm = int.Parse(ReaderAnnonce["NOTE_COMM"].ToString());

                    CollCommentaire.Add(NouveauCommentaire);
                }
                ReaderAnnonce.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        public String changeNameUserbyId(String idUser)
        {
            String nomEntier = idUser;
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM membre WHERE ID_MEMBRE=" + idUser + "";
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

        private void addDernierCommentaire(object sender, DataGridViewCellEventArgs e)
        {
            label_commentaire.Text = dataGridViewCommenaire.CurrentRow.Cells[4].Value.ToString();
            label_note.Text = dataGridViewCommenaire.CurrentRow.Cells[3].Value.ToString();
            label_auteur.Text = dataGridViewCommenaire.CurrentRow.Cells[1].Value.ToString();
            label_date.Text = dataGridViewCommenaire.CurrentRow.Cells[5].Value.ToString();
        }

        private void Recherhce(object sender, EventArgs e)
        {
            dataGridViewCommenaire.Rows.Clear();
            addListAnnonce(doSql());
            doRecherche();
        }

        private void BtnAnalyse_Click(object sender, EventArgs e)
        {
            AnalyseCommentaire Mafenetre = new AnalyseCommentaire(this.lien);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this.lien;
            Mafenetre.Show();
        }
    }
}
