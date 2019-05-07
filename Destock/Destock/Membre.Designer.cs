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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membre));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtNbMembre = new System.Windows.Forms.Label();
            this.ID_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MEMBRE,
            this.NOM_MEMBRE,
            this.PRENOM_MEMBRE,
            this.EMAIL_MEMBRE,
            this.ACTION});
            this.DataGridView1.Location = new System.Drawing.Point(333, 43);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(836, 614);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.changeActiviteDetail);
            // 
            // TextNom
            // 
            this.TextNom.Location = new System.Drawing.Point(143, 104);
            this.TextNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextNom.Name = "TextNom";
            this.TextNom.Size = new System.Drawing.Size(159, 22);
            this.TextNom.TabIndex = 1;
            this.TextNom.TextChanged += new System.EventHandler(this.BTN_Afficher);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Par Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Par Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Par Email";
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Location = new System.Drawing.Point(143, 153);
            this.TextBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(159, 22);
            this.TextBoxPrenom.TabIndex = 6;
            this.TextBoxPrenom.TextChanged += new System.EventHandler(this.BTN_Afficher);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(143, 201);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(159, 22);
            this.TextBoxEmail.TabIndex = 7;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.BTN_Afficher);
            // 
            // TxtNbMembre
            // 
            this.TxtNbMembre.AutoSize = true;
            this.TxtNbMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNbMembre.ForeColor = System.Drawing.Color.White;
            this.TxtNbMembre.Location = new System.Drawing.Point(331, 678);
            this.TxtNbMembre.Name = "TxtNbMembre";
            this.TxtNbMembre.Size = new System.Drawing.Size(0, 20);
            this.TxtNbMembre.TabIndex = 9;
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
            // ACTION
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Détails";
            this.ACTION.DefaultCellStyle = dataGridViewCellStyle1;
            this.ACTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACTION.HeaderText = "Actions";
            this.ACTION.Name = "ACTION";
            this.ACTION.Text = "Détails";
            this.ACTION.Width = 75;
            // 
            // Membre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1181, 719);
            this.Controls.Add(this.TxtNbMembre);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextNom);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label TxtNbMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_MEMBRE;
        private System.Windows.Forms.DataGridViewButtonColumn ACTION;
    }
}