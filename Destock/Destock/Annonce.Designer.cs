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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Annonce));
            this.dataGridViewAnnonce = new System.Windows.Forms.DataGridView();
            this.label_nb_total = new System.Windows.Forms.Label();
            this.label_en_ligne = new System.Windows.Forms.Label();
            this.progressBar_chargement = new System.Windows.Forms.ProgressBar();
            this.textBox_titre = new System.Windows.Forms.TextBox();
            this.label_titre = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.numericUpDown_prix_min = new System.Windows.Forms.NumericUpDown();
            this.label_prix_min = new System.Windows.Forms.Label();
            this.label_prix_max = new System.Windows.Forms.Label();
            this.numericUpDown_prix_max = new System.Windows.Forms.NumericUpDown();
            this.checkBox_prix = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VENDEUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnnonce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix_max)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnnonce
            // 
            this.dataGridViewAnnonce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAnnonce.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAnnonce.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAnnonce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnnonce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.VENDEUR,
            this.TITRE,
            this.PRIX,
            this.QUANTITE,
            this.DATE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAnnonce.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAnnonce.Location = new System.Drawing.Point(275, 12);
            this.dataGridViewAnnonce.Name = "dataGridViewAnnonce";
            this.dataGridViewAnnonce.Size = new System.Drawing.Size(747, 545);
            this.dataGridViewAnnonce.TabIndex = 0;
            // 
            // label_nb_total
            // 
            this.label_nb_total.AutoSize = true;
            this.label_nb_total.ForeColor = System.Drawing.Color.White;
            this.label_nb_total.Location = new System.Drawing.Point(9, 531);
            this.label_nb_total.Name = "label_nb_total";
            this.label_nb_total.Size = new System.Drawing.Size(13, 13);
            this.label_nb_total.TabIndex = 2;
            this.label_nb_total.Text = "0";
            // 
            // label_en_ligne
            // 
            this.label_en_ligne.AutoSize = true;
            this.label_en_ligne.ForeColor = System.Drawing.Color.White;
            this.label_en_ligne.Location = new System.Drawing.Point(9, 563);
            this.label_en_ligne.Name = "label_en_ligne";
            this.label_en_ligne.Size = new System.Drawing.Size(13, 13);
            this.label_en_ligne.TabIndex = 3;
            this.label_en_ligne.Text = "0";
            // 
            // progressBar_chargement
            // 
            this.progressBar_chargement.Location = new System.Drawing.Point(275, 563);
            this.progressBar_chargement.Name = "progressBar_chargement";
            this.progressBar_chargement.Size = new System.Drawing.Size(747, 13);
            this.progressBar_chargement.Step = 1;
            this.progressBar_chargement.TabIndex = 5;
            // 
            // textBox_titre
            // 
            this.textBox_titre.Location = new System.Drawing.Point(13, 37);
            this.textBox_titre.Name = "textBox_titre";
            this.textBox_titre.Size = new System.Drawing.Size(256, 20);
            this.textBox_titre.TabIndex = 6;
            this.textBox_titre.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // label_titre
            // 
            this.label_titre.AutoSize = true;
            this.label_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre.ForeColor = System.Drawing.Color.White;
            this.label_titre.Location = new System.Drawing.Point(12, 14);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(40, 20);
            this.label_titre.TabIndex = 7;
            this.label_titre.Text = "Titre";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(12, 70);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(108, 20);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "ID ANNONCE";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(13, 93);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(256, 20);
            this.textBox_id.TabIndex = 8;
            this.textBox_id.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_prix_min
            // 
            this.numericUpDown_prix_min.Location = new System.Drawing.Point(126, 152);
            this.numericUpDown_prix_min.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.numericUpDown_prix_min.Name = "numericUpDown_prix_min";
            this.numericUpDown_prix_min.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_prix_min.TabIndex = 10;
            this.numericUpDown_prix_min.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // label_prix_min
            // 
            this.label_prix_min.AutoSize = true;
            this.label_prix_min.ForeColor = System.Drawing.Color.White;
            this.label_prix_min.Location = new System.Drawing.Point(124, 136);
            this.label_prix_min.Name = "label_prix_min";
            this.label_prix_min.Size = new System.Drawing.Size(43, 13);
            this.label_prix_min.TabIndex = 11;
            this.label_prix_min.Text = "Prix min";
            // 
            // label_prix_max
            // 
            this.label_prix_max.AutoSize = true;
            this.label_prix_max.ForeColor = System.Drawing.Color.White;
            this.label_prix_max.Location = new System.Drawing.Point(196, 136);
            this.label_prix_max.Name = "label_prix_max";
            this.label_prix_max.Size = new System.Drawing.Size(46, 13);
            this.label_prix_max.TabIndex = 13;
            this.label_prix_max.Text = "Prix max";
            // 
            // numericUpDown_prix_max
            // 
            this.numericUpDown_prix_max.Location = new System.Drawing.Point(198, 152);
            this.numericUpDown_prix_max.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_prix_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_prix_max.Name = "numericUpDown_prix_max";
            this.numericUpDown_prix_max.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_prix_max.TabIndex = 12;
            this.numericUpDown_prix_max.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_prix_max.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_prix
            // 
            this.checkBox_prix.AutoSize = true;
            this.checkBox_prix.ForeColor = System.Drawing.Color.White;
            this.checkBox_prix.Location = new System.Drawing.Point(12, 152);
            this.checkBox_prix.Name = "checkBox_prix";
            this.checkBox_prix.Size = new System.Drawing.Size(100, 17);
            this.checkBox_prix.TabIndex = 14;
            this.checkBox_prix.Text = "Filtre sur les prix";
            this.checkBox_prix.UseVisualStyleBackColor = true;
            this.checkBox_prix.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "€";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // VENDEUR
            // 
            this.VENDEUR.HeaderText = "VENDEUR";
            this.VENDEUR.Name = "VENDEUR";
            this.VENDEUR.Width = 85;
            // 
            // TITRE
            // 
            this.TITRE.HeaderText = "TITRE";
            this.TITRE.Name = "TITRE";
            this.TITRE.Width = 64;
            // 
            // PRIX
            // 
            this.PRIX.HeaderText = "PRIX";
            this.PRIX.Name = "PRIX";
            this.PRIX.Width = 57;
            // 
            // QUANTITE
            // 
            this.QUANTITE.HeaderText = "QUANTITE";
            this.QUANTITE.Name = "QUANTITE";
            this.QUANTITE.Width = 87;
            // 
            // DATE
            // 
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            this.DATE.Width = 61;
            // 
            // Annonce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1034, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_prix);
            this.Controls.Add(this.label_prix_max);
            this.Controls.Add(this.numericUpDown_prix_max);
            this.Controls.Add(this.label_prix_min);
            this.Controls.Add(this.numericUpDown_prix_min);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_titre);
            this.Controls.Add(this.textBox_titre);
            this.Controls.Add(this.progressBar_chargement);
            this.Controls.Add(this.label_en_ligne);
            this.Controls.Add(this.label_nb_total);
            this.Controls.Add(this.dataGridViewAnnonce);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Annonce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Annonce";
            this.Load += new System.EventHandler(this.Annonce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnnonce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnnonce;
        private System.Windows.Forms.Label label_nb_total;
        private System.Windows.Forms.Label label_en_ligne;
        private System.Windows.Forms.ProgressBar progressBar_chargement;
        private System.Windows.Forms.TextBox textBox_titre;
        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.NumericUpDown numericUpDown_prix_min;
        private System.Windows.Forms.Label label_prix_min;
        private System.Windows.Forms.Label label_prix_max;
        private System.Windows.Forms.NumericUpDown numericUpDown_prix_max;
        private System.Windows.Forms.CheckBox checkBox_prix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VENDEUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}