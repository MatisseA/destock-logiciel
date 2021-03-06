﻿using System;
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
                addListAnnonce(doSql());
                doRecherche();

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

        public String doSql()
        {
            String requete;
            //requete de base pour tout afficher
            requete = "SELECT * FROM annonce WHERE ID_ANNC > 0";

            if(textBox_id.Text != "")
            {
                requete = requete + " AND ID_ANNC LIKE '%"+ textBox_id.Text + "%'";
            }
            if (textBox_titre.Text != "")
            {
                requete = requete + " AND TITRE_ANNC LIKE '%" + textBox_titre.Text + "%'";
            }
            if (textBox_date.Text != "")
            {
                requete = requete + " AND DATE_ANNC LIKE '%"+ textBox_date.Text +"%'";
            }
            if (checkBox_prix.Checked == true)
            {
                requete = requete + " AND (PRIXACT_ANNC BETWEEN '" + numericUpDown_prix_min.Value + "' AND '" + numericUpDown_prix_max.Value + "')";
            }
            if(checkBox_quantite.Checked == true)
            {
                requete = requete + " AND (QTE_ANNC BETWEEN '" + numericUpDown_quantite_min.Value + "' AND '" + numericUpDown_quantite_max.Value + "')";
            }

            requete = requete + " ORDER BY ID_ANNC";
            return requete;
        }

        public void doRecherche()
        {
            int i = 0;
            int u = 0;
            foreach (uneAnnonce laAnnonce in CollAnnonce)
            {
                if (laAnnonce.statut.ToString() != "deleted")
                {
                    String nomMembre = changeNameUserbyId(laAnnonce.id_membre.ToString());
                    dataGridViewAnnonce.Rows.Add(laAnnonce.id_annonce.ToString(), nomMembre, laAnnonce.titre.ToString(), laAnnonce.prix_actuelle.ToString() + "€", laAnnonce.quantite.ToString(), laAnnonce.date.ToString());
                    u++;
                }
                i++;
            }
            label_nb_total.Text = "Nombre total d'annonce:" + i.ToString();
            label_en_ligne.Text = "Nombre d'annonce visible:" + u.ToString();
        }

        public String changeNameUserbyId(String idUser)
        {
            String nomEntier = idUser;
            try
            {
                //Ouverture connexion
                GestConn.Open();
                //Requete SQL
                String ReqSql = "SELECT * FROM membre WHERE ID_MEMBRE="+ idUser +"";
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

        public void addListAnnonce(String requeteSQL)
        {
            try
            {
                progressBar_chargement.Visible = true;
                progressBar_chargement.Value = 0;
                CollAnnonce.Clear();
                //Ouverture connexion
                GestConn.Open();
                MySqlCommand MaCommande = new MySqlCommand(requeteSQL, GestConn);
                //Déclaration de Data Reader
                MySqlDataReader ReaderAnnonce;
                //Exécution de la requête
                ReaderAnnonce = MaCommande.ExecuteReader();
                //Nouveau contact
                uneAnnonce NouvelAnnonce;

                progressBar_chargement.Value = 15;
                while (ReaderAnnonce.Read())
                {
                    NouvelAnnonce.id_annonce = int.Parse(ReaderAnnonce["ID_ANNC"].ToString());
                    NouvelAnnonce.id_membre = int.Parse(ReaderAnnonce["ID_MEMBRE"].ToString());
                    NouvelAnnonce.titre = (ReaderAnnonce["TITRE_ANNC"].ToString());
                    NouvelAnnonce.description = (ReaderAnnonce["DESC_ANNC"].ToString());
                    NouvelAnnonce.image = (ReaderAnnonce["IMAGE_ANNC"].ToString());
                    NouvelAnnonce.prix_depart = Convert.ToDouble(ReaderAnnonce["PRIXDEP_ANNC"].ToString());
                    NouvelAnnonce.prix_actuelle = Convert.ToDouble(ReaderAnnonce["PRIXACT_ANNC"].ToString());
                    NouvelAnnonce.quantite = int.Parse(ReaderAnnonce["QTE_ANNC"].ToString());
                    NouvelAnnonce.date = (ReaderAnnonce["DATE_ANNC"].ToString());
                    NouvelAnnonce.type = (ReaderAnnonce["TYPE_ANNC"].ToString());
                    NouvelAnnonce.statut = (ReaderAnnonce["STATUT_ANNC"].ToString());
                    NouvelAnnonce.unite = (ReaderAnnonce["UNITE_ANNC"].ToString());

                    CollAnnonce.Add(NouvelAnnonce);
                }
                ReaderAnnonce.Close();
                GestConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            progressBar_chargement.Value = 100;
            progressBar_chargement.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewAnnonce.Rows.Clear();
            addListAnnonce(doSql());
            doRecherche();
        }

        private void changeActiviteDetail(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridViewAnnonce.CurrentRow.Cells[0].Value.ToString());

            DetailsAnnonce Mafenetre = new DetailsAnnonce(dataGridViewAnnonce.CurrentRow.Cells[0].Value.ToString(), this.lien);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this.lien;
            Mafenetre.Show();
        }
    }
}
