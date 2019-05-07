namespace Destock
{
    partial class Plainte
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
            this.dataGridViewPlainte = new System.Windows.Forms.DataGridView();
            this.TextTitre = new System.Windows.Forms.TextBox();
            this.TextAccuse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPlaignant = new System.Windows.Forms.TextBox();
            this.TxtNbPlainte = new System.Windows.Forms.Label();
            this.IDPLAINTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plaingnant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCUSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIONS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtNomPlaignant = new System.Windows.Forms.Label();
            this.TxtNomAccuse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlainte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlainte
            // 
            this.dataGridViewPlainte.AllowUserToAddRows = false;
            this.dataGridViewPlainte.AllowUserToDeleteRows = false;
            this.dataGridViewPlainte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.dataGridViewPlainte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlainte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPLAINTE,
            this.Plaingnant,
            this.ACCUSE,
            this.TITRE,
            this.ACTIONS});
            this.dataGridViewPlainte.Location = new System.Drawing.Point(384, 26);
            this.dataGridViewPlainte.Name = "dataGridViewPlainte";
            this.dataGridViewPlainte.RowTemplate.Height = 24;
            this.dataGridViewPlainte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlainte.Size = new System.Drawing.Size(925, 555);
            this.dataGridViewPlainte.TabIndex = 0;
            this.dataGridViewPlainte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangerInformation);
            this.dataGridViewPlainte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupprimerPlainte);
            // 
            // TextTitre
            // 
            this.TextTitre.Location = new System.Drawing.Point(147, 214);
            this.TextTitre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextTitre.Name = "TextTitre";
            this.TextTitre.Size = new System.Drawing.Size(193, 22);
            this.TextTitre.TabIndex = 14;
            this.TextTitre.TextChanged += new System.EventHandler(this.BTN_Afficher);
            // 
            // TextAccuse
            // 
            this.TextAccuse.Location = new System.Drawing.Point(219, 170);
            this.TextAccuse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextAccuse.Name = "TextAccuse";
            this.TextAccuse.Size = new System.Drawing.Size(121, 22);
            this.TextAccuse.TabIndex = 13;
            this.TextAccuse.TextChanged += new System.EventHandler(this.BTN_Afficher);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Par Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Par ID ACCUSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Par ID PLAIGNANT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtrer :";
            // 
            // TextPlaignant
            // 
            this.TextPlaignant.Location = new System.Drawing.Point(219, 123);
            this.TextPlaignant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextPlaignant.Name = "TextPlaignant";
            this.TextPlaignant.Size = new System.Drawing.Size(121, 22);
            this.TextPlaignant.TabIndex = 8;
            this.TextPlaignant.TextChanged += new System.EventHandler(this.BTN_Afficher);
            // 
            // TxtNbPlainte
            // 
            this.TxtNbPlainte.AutoSize = true;
            this.TxtNbPlainte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNbPlainte.ForeColor = System.Drawing.Color.White;
            this.TxtNbPlainte.Location = new System.Drawing.Point(380, 612);
            this.TxtNbPlainte.Name = "TxtNbPlainte";
            this.TxtNbPlainte.Size = new System.Drawing.Size(0, 20);
            this.TxtNbPlainte.TabIndex = 15;
            // 
            // IDPLAINTE
            // 
            this.IDPLAINTE.HeaderText = "ID PLAINTE";
            this.IDPLAINTE.Name = "IDPLAINTE";
            // 
            // Plaingnant
            // 
            this.Plaingnant.HeaderText = "ID PLAIGNANT";
            this.Plaingnant.Name = "Plaingnant";
            // 
            // ACCUSE
            // 
            this.ACCUSE.HeaderText = "ID ACCUSE";
            this.ACCUSE.Name = "ACCUSE";
            // 
            // TITRE
            // 
            this.TITRE.HeaderText = "Titre";
            this.TITRE.Name = "TITRE";
            this.TITRE.Width = 250;
            // 
            // ACTIONS
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Supprimer";
            this.ACTIONS.DefaultCellStyle = dataGridViewCellStyle1;
            this.ACTIONS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACTIONS.HeaderText = "Actions";
            this.ACTIONS.Name = "ACTIONS";
            this.ACTIONS.Text = "Supprimer";
            // 
            // TxtNomPlaignant
            // 
            this.TxtNomPlaignant.AutoSize = true;
            this.TxtNomPlaignant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomPlaignant.ForeColor = System.Drawing.Color.White;
            this.TxtNomPlaignant.Location = new System.Drawing.Point(27, 436);
            this.TxtNomPlaignant.Name = "TxtNomPlaignant";
            this.TxtNomPlaignant.Size = new System.Drawing.Size(133, 20);
            this.TxtNomPlaignant.TabIndex = 16;
            this.TxtNomPlaignant.Text = "Nom Plaignant : ";
            // 
            // TxtNomAccuse
            // 
            this.TxtNomAccuse.AutoSize = true;
            this.TxtNomAccuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomAccuse.ForeColor = System.Drawing.Color.White;
            this.TxtNomAccuse.Location = new System.Drawing.Point(27, 478);
            this.TxtNomAccuse.Name = "TxtNomAccuse";
            this.TxtNomAccuse.Size = new System.Drawing.Size(120, 20);
            this.TxtNomAccuse.TabIndex = 17;
            this.TxtNomAccuse.Text = "Nom Accusé : ";
            // 
            // Plainte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1343, 662);
            this.Controls.Add(this.TxtNomAccuse);
            this.Controls.Add(this.TxtNomPlaignant);
            this.Controls.Add(this.TxtNbPlainte);
            this.Controls.Add(this.TextTitre);
            this.Controls.Add(this.TextAccuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextPlaignant);
            this.Controls.Add(this.dataGridViewPlainte);
            this.Name = "Plainte";
            this.Text = "Plainte";
            this.Load += new System.EventHandler(this.Plainte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlainte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlainte;
        private System.Windows.Forms.TextBox TextTitre;
        private System.Windows.Forms.TextBox TextAccuse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPlaignant;
        private System.Windows.Forms.Label TxtNbPlainte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPLAINTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plaingnant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCUSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITRE;
        private System.Windows.Forms.DataGridViewButtonColumn ACTIONS;
        private System.Windows.Forms.Label TxtNomPlaignant;
        private System.Windows.Forms.Label TxtNomAccuse;
    }
}