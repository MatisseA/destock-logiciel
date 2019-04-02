namespace Destock
{
    partial class Commentaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel_dernier_commentaire = new System.Windows.Forms.TableLayoutPanel();
            this.label_auteur = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_commentaire = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_note = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_dernier_commentaire = new System.Windows.Forms.Label();
            this.dataGridViewCommenaire = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leCommentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_recherche = new System.Windows.Forms.TextBox();
            this.BtnAnalyse = new System.Windows.Forms.Button();
            this.label_alanyse_info = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_etat_chargement = new System.Windows.Forms.Label();
            this.label_etat = new System.Windows.Forms.Label();
            this.tableLayoutPanel_dernier_commentaire.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommenaire)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_dernier_commentaire
            // 
            this.tableLayoutPanel_dernier_commentaire.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel_dernier_commentaire.ColumnCount = 2;
            this.tableLayoutPanel_dernier_commentaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_dernier_commentaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_dernier_commentaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_dernier_commentaire.Controls.Add(this.label_auteur, 0, 0);
            this.tableLayoutPanel_dernier_commentaire.Controls.Add(this.label_date, 1, 0);
            this.tableLayoutPanel_dernier_commentaire.Controls.Add(this.label_commentaire, 1, 1);
            this.tableLayoutPanel_dernier_commentaire.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel_dernier_commentaire.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel_dernier_commentaire.Location = new System.Drawing.Point(12, 338);
            this.tableLayoutPanel_dernier_commentaire.Name = "tableLayoutPanel_dernier_commentaire";
            this.tableLayoutPanel_dernier_commentaire.RowCount = 2;
            this.tableLayoutPanel_dernier_commentaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel_dernier_commentaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel_dernier_commentaire.Size = new System.Drawing.Size(776, 100);
            this.tableLayoutPanel_dernier_commentaire.TabIndex = 1;
            // 
            // label_auteur
            // 
            this.label_auteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_auteur.ForeColor = System.Drawing.Color.Black;
            this.label_auteur.Location = new System.Drawing.Point(3, 0);
            this.label_auteur.Name = "label_auteur";
            this.label_auteur.Size = new System.Drawing.Size(149, 33);
            this.label_auteur.TabIndex = 0;
            this.label_auteur.Text = "Auteur";
            this.label_auteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_date
            // 
            this.label_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_date.ForeColor = System.Drawing.Color.Black;
            this.label_date.Location = new System.Drawing.Point(158, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(615, 33);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_commentaire
            // 
            this.label_commentaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_commentaire.ForeColor = System.Drawing.Color.Black;
            this.label_commentaire.Location = new System.Drawing.Point(158, 33);
            this.label_commentaire.Name = "label_commentaire";
            this.label_commentaire.Size = new System.Drawing.Size(615, 67);
            this.label_commentaire.TabIndex = 3;
            this.label_commentaire.Text = "Commentaire";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.97987F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.02013F));
            this.tableLayoutPanel1.Controls.Add(this.label_note, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 61);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label_note
            // 
            this.label_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_note.ForeColor = System.Drawing.Color.Black;
            this.label_note.Location = new System.Drawing.Point(3, 0);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(64, 61);
            this.label_note.TabIndex = 2;
            this.label_note.Text = "5";
            this.label_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::Destock.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(73, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_dernier_commentaire
            // 
            this.label_dernier_commentaire.AutoSize = true;
            this.label_dernier_commentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dernier_commentaire.ForeColor = System.Drawing.Color.White;
            this.label_dernier_commentaire.Location = new System.Drawing.Point(12, 317);
            this.label_dernier_commentaire.Name = "label_dernier_commentaire";
            this.label_dernier_commentaire.Size = new System.Drawing.Size(259, 18);
            this.label_dernier_commentaire.TabIndex = 2;
            this.label_dernier_commentaire.Text = "Prévisualisation de votre commentaire";
            // 
            // dataGridViewCommenaire
            // 
            this.dataGridViewCommenaire.AllowUserToAddRows = false;
            this.dataGridViewCommenaire.AllowUserToDeleteRows = false;
            this.dataGridViewCommenaire.AllowUserToOrderColumns = true;
            this.dataGridViewCommenaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCommenaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCommenaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommenaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Auteur,
            this.vendeur,
            this.Note,
            this.leCommentaire,
            this.Date,
            this.Action});
            this.dataGridViewCommenaire.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewCommenaire.Name = "dataGridViewCommenaire";
            this.dataGridViewCommenaire.Size = new System.Drawing.Size(776, 277);
            this.dataGridViewCommenaire.TabIndex = 3;
            this.dataGridViewCommenaire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addDernierCommentaire);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            this.Auteur.Width = 63;
            // 
            // vendeur
            // 
            this.vendeur.HeaderText = "Sur le profil de";
            this.vendeur.Name = "vendeur";
            this.vendeur.Width = 99;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.Width = 55;
            // 
            // leCommentaire
            // 
            this.leCommentaire.HeaderText = "Commentaire";
            this.leCommentaire.Name = "leCommentaire";
            this.leCommentaire.Visible = false;
            this.leCommentaire.Width = 93;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 55;
            // 
            // Action
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Visualiser";
            this.Action.DefaultCellStyle = dataGridViewCellStyle3;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Width = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(794, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recherche dans le commentaire";
            // 
            // textBox_recherche
            // 
            this.textBox_recherche.Location = new System.Drawing.Point(797, 57);
            this.textBox_recherche.Name = "textBox_recherche";
            this.textBox_recherche.Size = new System.Drawing.Size(199, 20);
            this.textBox_recherche.TabIndex = 5;
            this.textBox_recherche.TextChanged += new System.EventHandler(this.Recherche);
            // 
            // BtnAnalyse
            // 
            this.BtnAnalyse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.BtnAnalyse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnalyse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.BtnAnalyse.FlatAppearance.BorderSize = 0;
            this.BtnAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalyse.ForeColor = System.Drawing.Color.White;
            this.BtnAnalyse.Location = new System.Drawing.Point(797, 118);
            this.BtnAnalyse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAnalyse.Name = "BtnAnalyse";
            this.BtnAnalyse.Size = new System.Drawing.Size(199, 41);
            this.BtnAnalyse.TabIndex = 14;
            this.BtnAnalyse.Text = "Analyser les commentaires";
            this.BtnAnalyse.UseVisualStyleBackColor = false;
            this.BtnAnalyse.Click += new System.EventHandler(this.BtnAnalyse_Click);
            // 
            // label_alanyse_info
            // 
            this.label_alanyse_info.AutoSize = true;
            this.label_alanyse_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alanyse_info.ForeColor = System.Drawing.Color.Gray;
            this.label_alanyse_info.Location = new System.Drawing.Point(816, 161);
            this.label_alanyse_info.Name = "label_alanyse_info";
            this.label_alanyse_info.Size = new System.Drawing.Size(164, 9);
            this.label_alanyse_info.TabIndex = 15;
            this.label_alanyse_info.Text = "Cette opération peut prendre plusieurs minutes.";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(797, 173);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(199, 13);
            this.progressBar1.TabIndex = 16;
            // 
            // label_etat_chargement
            // 
            this.label_etat_chargement.AutoSize = true;
            this.label_etat_chargement.ForeColor = System.Drawing.Color.White;
            this.label_etat_chargement.Location = new System.Drawing.Point(794, 189);
            this.label_etat_chargement.Name = "label_etat_chargement";
            this.label_etat_chargement.Size = new System.Drawing.Size(67, 13);
            this.label_etat_chargement.TabIndex = 17;
            this.label_etat_chargement.Text = "Chargement:";
            // 
            // label_etat
            // 
            this.label_etat.AutoSize = true;
            this.label_etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_etat.ForeColor = System.Drawing.Color.White;
            this.label_etat.Location = new System.Drawing.Point(857, 189);
            this.label_etat.Name = "label_etat";
            this.label_etat.Size = new System.Drawing.Size(25, 13);
            this.label_etat.TabIndex = 18;
            this.label_etat.Text = "etat";
            // 
            // Commentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.label_etat);
            this.Controls.Add(this.label_etat_chargement);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_alanyse_info);
            this.Controls.Add(this.BtnAnalyse);
            this.Controls.Add(this.textBox_recherche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCommenaire);
            this.Controls.Add(this.label_dernier_commentaire);
            this.Controls.Add(this.tableLayoutPanel_dernier_commentaire);
            this.Name = "Commentaire";
            this.Text = "Commentaire";
            this.Load += new System.EventHandler(this.Commentaire_Load);
            this.tableLayoutPanel_dernier_commentaire.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommenaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_dernier_commentaire;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_auteur;
        private System.Windows.Forms.Label label_commentaire;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_dernier_commentaire;
        private System.Windows.Forms.DataGridView dataGridViewCommenaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn leCommentaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_recherche;
        private System.Windows.Forms.Button BtnAnalyse;
        private System.Windows.Forms.Label label_alanyse_info;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_etat_chargement;
        private System.Windows.Forms.Label label_etat;
    }
}