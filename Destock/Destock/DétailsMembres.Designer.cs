namespace Destock
{
    partial class DétailsMembres
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TxtPrenom = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.Label();
            this.TxtCP = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.Label();
            this.TxtAdresse = new System.Windows.Forms.Label();
            this.TxtVille = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.Label();
            this.TxtType = new System.Windows.Forms.Label();
            this.TxtValide = new System.Windows.Forms.Label();
            this.TxtArgent = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtImage = new System.Windows.Forms.Label();
            this.BtnValide = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(345, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voir le profil de cet utilisateur sur le site";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_redirection_site_LinkClicked);
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrenom.ForeColor = System.Drawing.Color.White;
            this.TxtPrenom.Location = new System.Drawing.Point(459, 18);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(621, 45);
            this.TxtPrenom.TabIndex = 1;
            this.TxtPrenom.Text = "Nom Prenom";
            // 
            // Txtid
            // 
            this.Txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtid.ForeColor = System.Drawing.Color.White;
            this.Txtid.Location = new System.Drawing.Point(15, 74);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(253, 23);
            this.Txtid.TabIndex = 2;
            this.Txtid.Text = "id : ";
            // 
            // TxtCP
            // 
            this.TxtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCP.ForeColor = System.Drawing.Color.White;
            this.TxtCP.Location = new System.Drawing.Point(15, 234);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(253, 23);
            this.TxtCP.TabIndex = 3;
            this.TxtCP.Text = "Code Postal : ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.Location = new System.Drawing.Point(15, 115);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(253, 23);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.Text = "EMail : ";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdresse.ForeColor = System.Drawing.Color.White;
            this.TxtAdresse.Location = new System.Drawing.Point(15, 192);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(253, 23);
            this.TxtAdresse.TabIndex = 5;
            this.TxtAdresse.Text = "Adresse : ";
            // 
            // TxtVille
            // 
            this.TxtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVille.ForeColor = System.Drawing.Color.White;
            this.TxtVille.Location = new System.Drawing.Point(15, 153);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(253, 23);
            this.TxtVille.TabIndex = 6;
            this.TxtVille.Text = "Ville : ";
            // 
            // TxtTel
            // 
            this.TxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTel.ForeColor = System.Drawing.Color.White;
            this.TxtTel.Location = new System.Drawing.Point(19, 274);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(289, 72);
            this.TxtTel.TabIndex = 7;
            this.TxtTel.Text = "Téléphone : ";
            // 
            // TxtType
            // 
            this.TxtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtType.ForeColor = System.Drawing.Color.White;
            this.TxtType.Location = new System.Drawing.Point(19, 315);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(289, 72);
            this.TxtType.TabIndex = 8;
            this.TxtType.Text = "Type : ";
            // 
            // TxtValide
            // 
            this.TxtValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValide.ForeColor = System.Drawing.Color.White;
            this.TxtValide.Location = new System.Drawing.Point(19, 359);
            this.TxtValide.Name = "TxtValide";
            this.TxtValide.Size = new System.Drawing.Size(289, 72);
            this.TxtValide.TabIndex = 9;
            this.TxtValide.Text = "Validé : ";
            // 
            // TxtArgent
            // 
            this.TxtArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArgent.ForeColor = System.Drawing.Color.White;
            this.TxtArgent.Location = new System.Drawing.Point(19, 401);
            this.TxtArgent.Name = "TxtArgent";
            this.TxtArgent.Size = new System.Drawing.Size(289, 72);
            this.TxtArgent.TabIndex = 10;
            this.TxtArgent.Text = "Argent : ";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDesc.ForeColor = System.Drawing.Color.White;
            this.TxtDesc.Location = new System.Drawing.Point(461, 110);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(563, 186);
            this.TxtDesc.TabIndex = 11;
            this.TxtDesc.Text = "Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(803, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TxtImage
            // 
            this.TxtImage.AutoSize = true;
            this.TxtImage.ForeColor = System.Drawing.Color.White;
            this.TxtImage.Location = new System.Drawing.Point(790, 400);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Size = new System.Drawing.Size(259, 17);
            this.TxtImage.TabIndex = 13;
            this.TxtImage.Text = "Cet utilisateur n\'a pas de photo de profil";
            this.TxtImage.Visible = false;
            // 
            // BtnValide
            // 
            this.BtnValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValide.Location = new System.Drawing.Point(390, 434);
            this.BtnValide.Name = "BtnValide";
            this.BtnValide.Size = new System.Drawing.Size(151, 72);
            this.BtnValide.TabIndex = 14;
            this.BtnValide.Text = "Valider";
            this.BtnValide.UseVisualStyleBackColor = false;
            this.BtnValide.Click += new System.EventHandler(this.BtnValide_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(562, 434);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(152, 72);
            this.BtnSupprimer.TabIndex = 15;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // DétailsMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1102, 546);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnValide);
            this.Controls.Add(this.TxtImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtArgent);
            this.Controls.Add(this.TxtValide);
            this.Controls.Add(this.TxtType);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtVille);
            this.Controls.Add(this.TxtAdresse);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.linkLabel1);
            this.Name = "DétailsMembres";
            this.Text = "Détails du membre";
            this.Load += new System.EventHandler(this.DétailsMembres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label TxtPrenom;
        private System.Windows.Forms.Label Txtid;
        private System.Windows.Forms.Label TxtCP;
        private System.Windows.Forms.Label TxtEmail;
        private System.Windows.Forms.Label TxtAdresse;
        private System.Windows.Forms.Label TxtVille;
        private System.Windows.Forms.Label TxtTel;
        private System.Windows.Forms.Label TxtType;
        private System.Windows.Forms.Label TxtValide;
        private System.Windows.Forms.Label TxtArgent;
        private System.Windows.Forms.Label TxtDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TxtImage;
        private System.Windows.Forms.Button BtnValide;
        private System.Windows.Forms.Button BtnSupprimer;
    }
}