namespace Destock
{
    partial class DetailsAnnonce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsAnnonce));
            this.label_txt_id_annonce = new System.Windows.Forms.Label();
            this.label_id_annonce = new System.Windows.Forms.Label();
            this.label_txt_titre = new System.Windows.Forms.Label();
            this.linkLabel_redirection_site = new System.Windows.Forms.LinkLabel();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.label_no_image = new System.Windows.Forms.Label();
            this.label_txt_description = new System.Windows.Forms.Label();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_auteur = new System.Windows.Forms.Label();
            this.label_txt_auteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_txt_id_annonce
            // 
            this.label_txt_id_annonce.AutoSize = true;
            this.label_txt_id_annonce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt_id_annonce.ForeColor = System.Drawing.Color.White;
            this.label_txt_id_annonce.Location = new System.Drawing.Point(93, 26);
            this.label_txt_id_annonce.Name = "label_txt_id_annonce";
            this.label_txt_id_annonce.Size = new System.Drawing.Size(13, 13);
            this.label_txt_id_annonce.TabIndex = 0;
            this.label_txt_id_annonce.Text = "0";
            // 
            // label_id_annonce
            // 
            this.label_id_annonce.AutoSize = true;
            this.label_id_annonce.ForeColor = System.Drawing.Color.White;
            this.label_id_annonce.Location = new System.Drawing.Point(4, 26);
            this.label_id_annonce.Name = "label_id_annonce";
            this.label_id_annonce.Size = new System.Drawing.Size(83, 13);
            this.label_id_annonce.TabIndex = 1;
            this.label_id_annonce.Text = "Id de l\'annonce:";
            // 
            // label_txt_titre
            // 
            this.label_txt_titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_txt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt_titre.ForeColor = System.Drawing.Color.White;
            this.label_txt_titre.Location = new System.Drawing.Point(153, 9);
            this.label_txt_titre.Name = "label_txt_titre";
            this.label_txt_titre.Size = new System.Drawing.Size(635, 23);
            this.label_txt_titre.TabIndex = 2;
            this.label_txt_titre.Text = "Titre";
            this.label_txt_titre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel_redirection_site
            // 
            this.linkLabel_redirection_site.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel_redirection_site.AutoSize = true;
            this.linkLabel_redirection_site.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.linkLabel_redirection_site.Location = new System.Drawing.Point(4, 9);
            this.linkLabel_redirection_site.Name = "linkLabel_redirection_site";
            this.linkLabel_redirection_site.Size = new System.Drawing.Size(134, 13);
            this.linkLabel_redirection_site.TabIndex = 3;
            this.linkLabel_redirection_site.TabStop = true;
            this.linkLabel_redirection_site.Text = "Voir l\'annonce sur Destock";
            this.linkLabel_redirection_site.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.linkLabel_redirection_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_redirection_site_LinkClicked);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(530, 216);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(258, 222);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 4;
            this.pictureBox_image.TabStop = false;
            // 
            // label_no_image
            // 
            this.label_no_image.AutoSize = true;
            this.label_no_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_no_image.ForeColor = System.Drawing.Color.White;
            this.label_no_image.Location = new System.Drawing.Point(572, 324);
            this.label_no_image.Name = "label_no_image";
            this.label_no_image.Size = new System.Drawing.Size(185, 13);
            this.label_no_image.TabIndex = 5;
            this.label_no_image.Text = "Il n\'y a pas d\'image sur cette annonce";
            this.label_no_image.Visible = false;
            // 
            // label_txt_description
            // 
            this.label_txt_description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_txt_description.ForeColor = System.Drawing.Color.White;
            this.label_txt_description.Location = new System.Drawing.Point(158, 47);
            this.label_txt_description.Name = "label_txt_description";
            this.label_txt_description.Size = new System.Drawing.Size(630, 166);
            this.label_txt_description.TabIndex = 6;
            this.label_txt_description.Text = "Description";
            this.label_txt_description.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.BtnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.BtnSupprimer.FlatAppearance.BorderSize = 0;
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.Location = new System.Drawing.Point(403, 404);
            this.BtnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(122, 34);
            this.BtnSupprimer.TabIndex = 14;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(76)))), ((int)(((byte)(101)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(268, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Premium";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_auteur
            // 
            this.label_auteur.AutoSize = true;
            this.label_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auteur.ForeColor = System.Drawing.Color.White;
            this.label_auteur.Location = new System.Drawing.Point(7, 425);
            this.label_auteur.Name = "label_auteur";
            this.label_auteur.Size = new System.Drawing.Size(98, 13);
            this.label_auteur.TabIndex = 16;
            this.label_auteur.Text = "Annonce créée par";
            // 
            // label_txt_auteur
            // 
            this.label_txt_auteur.AutoSize = true;
            this.label_txt_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt_auteur.ForeColor = System.Drawing.Color.White;
            this.label_txt_auteur.Location = new System.Drawing.Point(111, 421);
            this.label_txt_auteur.Name = "label_txt_auteur";
            this.label_txt_auteur.Size = new System.Drawing.Size(101, 20);
            this.label_txt_auteur.TabIndex = 17;
            this.label_txt_auteur.Text = "Nom Prénom";
            // 
            // DetailsAnnonce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_txt_auteur);
            this.Controls.Add(this.label_auteur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.label_txt_description);
            this.Controls.Add(this.label_no_image);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.linkLabel_redirection_site);
            this.Controls.Add(this.label_txt_titre);
            this.Controls.Add(this.label_id_annonce);
            this.Controls.Add(this.label_txt_id_annonce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailsAnnonce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details de l\'annonce";
            this.Load += new System.EventHandler(this.DetailsAnnonce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_txt_id_annonce;
        private System.Windows.Forms.Label label_id_annonce;
        private System.Windows.Forms.Label label_txt_titre;
        private System.Windows.Forms.LinkLabel linkLabel_redirection_site;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Label label_no_image;
        private System.Windows.Forms.Label label_txt_description;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_auteur;
        private System.Windows.Forms.Label label_txt_auteur;
    }
}