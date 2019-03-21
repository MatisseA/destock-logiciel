namespace Destock
{
    partial class Annonce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Annonce));
            this.dataGridViewAnnonce = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_nb_total = new System.Windows.Forms.Label();
            this.label_en_ligne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnnonce)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnnonce
            // 
            this.dataGridViewAnnonce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnnonce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_MEMBRE,
            this.TITRE,
            this.PRIX,
            this.QUANTITE,
            this.DATE});
            this.dataGridViewAnnonce.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewAnnonce.Name = "dataGridViewAnnonce";
            this.dataGridViewAnnonce.Size = new System.Drawing.Size(782, 377);
            this.dataGridViewAnnonce.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ID_MEMBRE
            // 
            this.ID_MEMBRE.HeaderText = "ID MEMBRE";
            this.ID_MEMBRE.Name = "ID_MEMBRE";
            // 
            // TITRE
            // 
            this.TITRE.HeaderText = "TITRE";
            this.TITRE.Name = "TITRE";
            // 
            // PRIX
            // 
            this.PRIX.HeaderText = "PRIX";
            this.PRIX.Name = "PRIX";
            // 
            // QUANTITE
            // 
            this.QUANTITE.HeaderText = "QUANTITE";
            this.QUANTITE.Name = "QUANTITE";
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // label_nb_total
            // 
            this.label_nb_total.AutoSize = true;
            this.label_nb_total.Location = new System.Drawing.Point(165, 459);
            this.label_nb_total.Name = "label_nb_total";
            this.label_nb_total.Size = new System.Drawing.Size(13, 13);
            this.label_nb_total.TabIndex = 2;
            this.label_nb_total.Text = "0";
            // 
            // label_en_ligne
            // 
            this.label_en_ligne.AutoSize = true;
            this.label_en_ligne.Location = new System.Drawing.Point(536, 458);
            this.label_en_ligne.Name = "label_en_ligne";
            this.label_en_ligne.Size = new System.Drawing.Size(13, 13);
            this.label_en_ligne.TabIndex = 3;
            this.label_en_ligne.Text = "0";
            // 
            // Annonce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 585);
            this.Controls.Add(this.label_en_ligne);
            this.Controls.Add(this.label_nb_total);
            this.Controls.Add(this.dataGridViewAnnonce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Annonce";
            this.Text = "Annonce";
            this.Load += new System.EventHandler(this.Annonce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnnonce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnnonce;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.Label label_nb_total;
        private System.Windows.Forms.Label label_en_ligne;
    }
}