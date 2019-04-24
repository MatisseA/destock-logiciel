using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                CollCommentaire.Clear();
                addListCommentaire(doSql());
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
            richTextBox_commentaire.Text = dataGridViewCommenaire.CurrentRow.Cells[4].Value.ToString();
            label_id.Text = dataGridViewCommenaire.CurrentRow.Cells[0].Value.ToString();
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

        public void addListCommentaire(String requeteSQL)
        {
            try
            {
                //Ouverture connexion
                GestConn.Open();
                MySqlCommand MaCommande = new MySqlCommand(requeteSQL, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderCommentaire;
                //Exécution de la requête
                ReaderCommentaire = MaCommande.ExecuteReader();
                //Nouveau contact
                unCommentaire NouveauCommentaire;
                
                while (ReaderCommentaire.Read())
                {
                    NouveauCommentaire.id_comm = int.Parse(ReaderCommentaire["ID_COMM"].ToString());
                    NouveauCommentaire.id_membre = int.Parse(ReaderCommentaire["ID_MEMBRE"].ToString());
                    NouveauCommentaire.id_vendeur_com = int.Parse(ReaderCommentaire["ID_VENDEUR_COM"].ToString());
                    NouveauCommentaire.txt_comm = (ReaderCommentaire["TXT_COMM"].ToString());
                    NouveauCommentaire.date_com = (ReaderCommentaire["DATE_COMM"].ToString());
                    NouveauCommentaire.note_comm = int.Parse(ReaderCommentaire["NOTE_COMM"].ToString());

                    CollCommentaire.Add(NouveauCommentaire);
                }
                ReaderCommentaire.Close();
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
            tableLayoutPanel_dernier_commentaire.BackColor = Color.FromArgb(224, 224, 224);
            label_id.Text = dataGridViewCommenaire.CurrentRow.Cells[0].Value.ToString();
            richTextBox_commentaire.Text = dataGridViewCommenaire.CurrentRow.Cells[4].Value.ToString();
            label_note.Text = dataGridViewCommenaire.CurrentRow.Cells[3].Value.ToString();
            label_auteur.Text = dataGridViewCommenaire.CurrentRow.Cells[1].Value.ToString();
            label_date.Text = dataGridViewCommenaire.CurrentRow.Cells[5].Value.ToString();
        }

        private void Recherche(object sender, EventArgs e)
        {
            if (textBox_recherche.Text.Length >= 3)
            {
                dataGridViewCommenaire.Rows.Clear();
                CollCommentaire.Clear();
                addListCommentaire(doSql());
                doRecherche();
            }
        }

        private void BtnAnalyse_Click(object sender, EventArgs e)
        {
            List<String> listMot = addListWord();
            int resultat = 0;
            Boolean trouver = false;
            foreach (String leMot in listMot)
            {
                resultat = richTextBox_commentaire.Find(leMot, 0, richTextBox_commentaire.Text.Length, RichTextBoxFinds.MatchCase);
                
                if (resultat > 0)
                {
                    MessageBox.Show("Possible mot dans le commentaire: " + leMot);
                    trouver = true;
                }
            }
            if (trouver == true)
            {
                tableLayoutPanel_dernier_commentaire.BackColor = Color.FromArgb(255, 128, 128);
            }
            else { 
                tableLayoutPanel_dernier_commentaire.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        //Met tout les mots qui sont dans le fichier, dans une liste
        private List<String> addListWord()
        {
            const String fileName = "bad-words.txt";
            List<String> lines = new List<String>();
            
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Use while not null pattern in while loop.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Met l'annonce en statut premium (couleur jaune à l'affichage)
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "DELETE FROM commentaire WHERE ID_COMM=" + label_id.Text;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderMembre;
                //Exécution de la requête
                ReaderMembre = MaCommande.ExecuteReader();
                ReaderMembre.Close();
                GestConn.Close();
                MessageBox.Show("Le commentaire est maintenant supprimé.");
                addListCommentaire(doSql());
                doRecherche();
                dataGridViewCommenaire.Rows.Clear();
                CollCommentaire.Clear();
                addDernierCommentaire();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
