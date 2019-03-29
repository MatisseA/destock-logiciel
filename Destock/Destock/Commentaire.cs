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
    }
}
