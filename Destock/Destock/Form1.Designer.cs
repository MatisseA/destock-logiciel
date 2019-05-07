namespace Destock
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConn = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDeco = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCréa = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMgerer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAnnonce = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMembre = new System.Windows.Forms.ToolStripMenuItem();
            this.commentaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSStext = new System.Windows.Forms.ToolStripStatusLabel();
            this.plainteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.TSMgerer,
            this.statistiquesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(999, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMConn,
            this.TSMDeco,
            this.TSMCréa,
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // TSMConn
            // 
            this.TSMConn.Name = "TSMConn";
            this.TSMConn.Size = new System.Drawing.Size(241, 26);
            this.TSMConn.Text = "Se connecter";
            this.TSMConn.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // TSMDeco
            // 
            this.TSMDeco.Enabled = false;
            this.TSMDeco.Name = "TSMDeco";
            this.TSMDeco.Size = new System.Drawing.Size(241, 26);
            this.TSMDeco.Text = "Se déconnecter";
            this.TSMDeco.Click += new System.EventHandler(this.TSMDeco_Click);
            // 
            // TSMCréa
            // 
            this.TSMCréa.Name = "TSMCréa";
            this.TSMCréa.Size = new System.Drawing.Size(241, 26);
            this.TSMCréa.Text = "Création compte admin";
            this.TSMCréa.Click += new System.EventHandler(this.créationCompteAdminToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // TSMgerer
            // 
            this.TSMgerer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAnnonce,
            this.TSMMembre,
            this.commentaireToolStripMenuItem,
            this.plainteToolStripMenuItem});
            this.TSMgerer.Enabled = false;
            this.TSMgerer.Name = "TSMgerer";
            this.TSMgerer.Size = new System.Drawing.Size(57, 24);
            this.TSMgerer.Text = "Gérer";
            // 
            // TSMAnnonce
            // 
            this.TSMAnnonce.Name = "TSMAnnonce";
            this.TSMAnnonce.Size = new System.Drawing.Size(181, 26);
            this.TSMAnnonce.Text = "Annonce";
            this.TSMAnnonce.Click += new System.EventHandler(this.TSMAnnonce_Click);
            // 
            // TSMMembre
            // 
            this.TSMMembre.Name = "TSMMembre";
            this.TSMMembre.Size = new System.Drawing.Size(181, 26);
            this.TSMMembre.Text = "Membre";
            this.TSMMembre.Click += new System.EventHandler(this.TSMMembre_Click);
            // 
            // commentaireToolStripMenuItem
            // 
            this.commentaireToolStripMenuItem.Name = "commentaireToolStripMenuItem";
            this.commentaireToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.commentaireToolStripMenuItem.Text = "Commentaire";
            this.commentaireToolStripMenuItem.Click += new System.EventHandler(this.commentaireToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Enabled = false;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSStext});
            this.statusStrip1.Location = new System.Drawing.Point(0, 630);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(999, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSStext
            // 
            this.TSStext.Name = "TSStext";
            this.TSStext.Size = new System.Drawing.Size(173, 20);
            this.TSStext.Text = "Vous n\'êtes pas connecté";
            // 
            // plainteToolStripMenuItem
            // 
            this.plainteToolStripMenuItem.Name = "plainteToolStripMenuItem";
            this.plainteToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.plainteToolStripMenuItem.Text = "Plainte";
            this.plainteToolStripMenuItem.Click += new System.EventHandler(this.plainteToolStripMenuItem_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipale";
            this.Text = "ADMINISTRATION DESKTOP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMCréa;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem TSMConn;
        public System.Windows.Forms.ToolStripMenuItem TSMDeco;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel TSStext;
        public System.Windows.Forms.ToolStripMenuItem TSMAnnonce;
        public System.Windows.Forms.ToolStripMenuItem TSMMembre;
        private System.Windows.Forms.ToolStripMenuItem commentaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plainteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem TSMgerer;
        public System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
    }
}

