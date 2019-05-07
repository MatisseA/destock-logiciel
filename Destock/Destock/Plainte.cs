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
    public partial class Plainte : Form
    {
        FormPrincipale lien;
        public Plainte(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        public List<Plaintes> CollPlainte;
        public String ChaineConnexion;
        public MySqlConnection GestConn;

        private void Plainte_Load(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base
                ChaineConnexion = "server=btsinfo-rousseau53.fr;port=33017;user=2017-destock;password=matissepierre;database=2017-destock_bdd;encrypt=false";
                //Création de la connexion
                GestConn = new MySqlConnection(ChaineConnexion);
                CollPlainte = new List<Plaintes>();
                ChargementCollectionPlainte(doSql());

                DoRecherche();

            }
            catch (Exception ex) { MessageBox.Show("Erreur Load : " + ex.Message); }
        }

        public struct Plaintes
        {
            public int id_plainte;
            public int id_plaignant;
            public int id_accuse;
            public String titre;
            public String desc;
        }

        private void ChargementCollectionPlainte(String requeteSQL)
        {
            try
            {
                CollPlainte.Clear();
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                MySqlCommand MaCommande = new MySqlCommand(requeteSQL, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderPlainte;
                //Exécution de la requête
                ReaderPlainte = MaCommande.ExecuteReader();
                //Nouveau contact
                Plaintes NouvellePlainte;

                while (ReaderPlainte.Read())
                {
                    NouvellePlainte.id_plainte = int.Parse(ReaderPlainte["ID_PLAINTE"].ToString());
                    NouvellePlainte.id_plaignant = int.Parse(ReaderPlainte["ID_PLAIGNANT"].ToString());
                    NouvellePlainte.id_accuse = int.Parse(ReaderPlainte["ID_ACCUSE"].ToString());
                    NouvellePlainte.titre = (ReaderPlainte["TITRE_PLAINTE"].ToString());
                    NouvellePlainte.desc = (ReaderPlainte["DESC_PLAINTE"].ToString());

                    CollPlainte.Add(NouvellePlainte);
                }

                ReaderPlainte.Close();
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

            requete = "SELECT * FROM plainte WHERE ID_PLAINTE > 0";

            if (TextPlaignant.Text != "")
            {
                requete = requete + " AND ID_PLAIGNANT LIKE '%" + TextPlaignant.Text + "%'";
            }
            if (TextAccuse.Text != "")
            {
                requete = requete + " AND ID_ACCUSE LIKE '%" + TextAccuse.Text + "%'";
            }
            if (TextTitre.Text != "")
            {
                requete = requete + " AND TITRE_PLAINTE LIKE '%" + TextTitre.Text + "%'";
            }


            requete = requete + " ORDER BY ID_PLAINTE";
            return requete;
        }

        public void DoRecherche()
        {
            int i = 0;
            foreach (Plaintes unePlainte in CollPlainte)
            {
                dataGridViewPlainte.Rows.Add(unePlainte.id_plainte.ToString(), unePlainte.id_plaignant.ToString(), unePlainte.id_accuse.ToString(), unePlainte.titre.ToString());
                i++;
            }
            TxtNbPlainte.Text = i + " plaintes affichées";
        }

        private void BTN_Afficher(object sender, EventArgs e)
        {
            dataGridViewPlainte.Rows.Clear();
            ChargementCollectionPlainte(doSql());
            DoRecherche();
        }

        private void SupprimerPlainte(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "DELETE FROM plainte WHERE ID_PLAINTE=" + dataGridViewPlainte.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderPlainte;
                //Exécution de la requête
                ReaderPlainte = MaCommande.ExecuteReader();
                ReaderPlainte.Close();
                GestConn.Close();
                MessageBox.Show("Cette plainte est maintenant supprimée.");
                dataGridViewPlainte.Rows.Clear();
                ChargementCollectionPlainte(doSql());
                DoRecherche();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void ChangerInformation(object sender, DataGridViewCellEventArgs e)
        {
            Plaintes LaPlainte = new Plaintes();
            LaPlainte = RecupererPlainteSelectionne();

            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM membre WHERE ID_MEMBRE=" + LaPlainte.id_plaignant;
                String ReqSql2 = "SELECT * FROM membre WHERE ID_MEMBRE=" + LaPlainte.id_accuse;
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                MySqlCommand MaCommande2 = new MySqlCommand(ReqSql2, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderPlainte;
                //Exécution de la requête
                ReaderPlainte = MaCommande.ExecuteReader();

                while (ReaderPlainte.Read())
                {
                    TxtNomPlaignant.Text = "Nom Plaignant : " + (ReaderPlainte["NOM_MEMBRE"].ToString()) + " " + (ReaderPlainte["PRENOM_MEMBRE"].ToString());
                }
                ReaderPlainte.Close();

                ReaderPlainte = MaCommande2.ExecuteReader();
                while (ReaderPlainte.Read())
                {
                    TxtNomAccuse.Text = "Nom Accusé : " + (ReaderPlainte["NOM_MEMBRE"].ToString()) + " " + (ReaderPlainte["PRENOM_MEMBRE"].ToString());
                }
                ReaderPlainte.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        public Plaintes RecupererPlainteSelectionne()
        {
            Plaintes PlainteSelectionne = new Plaintes();
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM plainte WHERE ID_PLAINTE=" + dataGridViewPlainte.CurrentRow.Cells[0].Value.ToString();
                MySqlCommand MaCommande = new MySqlCommand(ReqSql, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderPlainte;
                //Exécution de la requête
                ReaderPlainte = MaCommande.ExecuteReader();
                

                while (ReaderPlainte.Read())
                {
                    PlainteSelectionne.id_plaignant = int.Parse(ReaderPlainte["ID_PLAIGNANT"].ToString());
                    PlainteSelectionne.id_accuse = int.Parse(ReaderPlainte["ID_ACCUSE"].ToString());
                }

                ReaderPlainte.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);    
            }
            return PlainteSelectionne;
        }
    }
}
