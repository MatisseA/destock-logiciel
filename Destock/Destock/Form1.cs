﻿using System;
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
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void créationCompteAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscription Mafenetre = new Inscription();
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connexion Mafenetre = new Connexion(this);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }

        private void TSMDeco_Click(object sender, EventArgs e)
        {
            TSMgerer.Enabled = false;
            statistiquesToolStripMenuItem.Enabled = false;
            TSStext.Text = "Vous n'êtes pas connecté";
            MessageBox.Show("Vous êtes déconnecté");
        }

        private void TSMMembre_Click(object sender, EventArgs e)
        {
            Membre Mafenetre = new Membre(this);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }

        private void TSMAnnonce_Click(object sender, EventArgs e)
        {
            Annonce Mafenetre = new Annonce(this);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }

        private void commentaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commentaire Mafenetre = new Commentaire(this);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistique Mafenetre = new Statistique(this);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }

        private void plainteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plainte Mafenetre = new Plainte(this);
            Mafenetre.Owner = this;
            Mafenetre.MdiParent = this;
            Mafenetre.Show();
        }
    }
}
