namespace Destock
{
    partial class Membre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membre));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.BtnFiltrer = new System.Windows.Forms.Button();
            this.TxtNbMembre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MEMBRE,
            this.NOM_MEMBRE,
            this.PRENOM_MEMBRE,
            this.EMAIL_MEMBRE});
            this.DataGridView1.Location = new System.Drawing.Point(250, 35);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(556, 499);
            this.DataGridView1.TabIndex = 0;
            // 
            // ID_MEMBRE
            // 
            this.ID_MEMBRE.HeaderText = "ID";
            this.ID_MEMBRE.MaxInputLength = 10;
            this.ID_MEMBRE.Name = "ID_MEMBRE";
            this.ID_MEMBRE.Width = 75;
            // 
            // NOM_MEMBRE
            // 
            this.NOM_MEMBRE.HeaderText = "Nom";
            this.NOM_MEMBRE.MaxInputLength = 25;
            this.NOM_MEMBRE.Name = "NOM_MEMBRE";
            this.NOM_MEMBRE.Width = 120;
            // 
            // PRENOM_MEMBRE
            // 
            this.PRENOM_MEMBRE.HeaderText = "Prenom";
            this.PRENOM_MEMBRE.MaxInputLength = 25;
            this.PRENOM_MEMBRE.Name = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.Width = 120;
            // 
            // EMAIL_MEMBRE
            // 
            this.EMAIL_MEMBRE.HeaderText = "Email";
            this.EMAIL_MEMBRE.MaxInputLength = 50;
            this.EMAIL_MEMBRE.Name = "EMAIL_MEMBRE";
            this.EMAIL_MEMBRE.Width = 200;
            // 
            // TextNom
            // 
            this.TextNom.Location = new System.Drawing.Point(107, 108);
            this.TextNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextNom.Name = "TextNom";
            this.TextNom.Size = new System.Drawing.Size(120, 20);
            this.TextNom.TabIndex = 1;
            this.TextNom.TextChanged += new System.EventHandler(this.TextNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Par Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Par Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Par Email";
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Location = new System.Drawing.Point(107, 155);
            this.TextBoxPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(120, 20);
            this.TextBoxPrenom.TabIndex = 6;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(107, 200);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.TextBoxEmail.TabIndex = 7;
            // 
            // BtnFiltrer
            // 
            this.BtnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrer.Location = new System.Drawing.Point(80, 255);
            this.BtnFiltrer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFiltrer.Name = "BtnFiltrer";
            this.BtnFiltrer.Size = new System.Drawing.Size(92, 34);
            this.BtnFiltrer.TabIndex = 8;
            this.BtnFiltrer.Text = "Filtrer";
            this.BtnFiltrer.UseVisualStyleBackColor = true;
            this.BtnFiltrer.Click += new System.EventHandler(this.BTNAfficher_Click);
            // 
            // TxtNbMembre
            // 
            this.TxtNbMembre.AutoSize = true;
            this.TxtNbMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNbMembre.Location = new System.Drawing.Point(248, 551);
            this.TxtNbMembre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtNbMembre.Name = "TxtNbMembre";
            this.TxtNbMembre.Size = new System.Drawing.Size(0, 17);
            this.TxtNbMembre.TabIndex = 9;
            // 
            // Membre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 584);
            this.Controls.Add(this.TxtNbMembre);
            this.Controls.Add(this.BtnFiltrer);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextNom);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Membre";
            this.Text = "Membre";
            this.Load += new System.EventHandler(this.Membre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox TextNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxPrenom;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button BtnFiltrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_MEMBRE;
        private System.Windows.Forms.Label TxtNbMembre;
    }
}