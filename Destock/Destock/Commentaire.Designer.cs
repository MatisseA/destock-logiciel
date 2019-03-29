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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fenetre1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_dernier_commentaire = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.label_commentaire = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_dernier_commentaire = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel_dernier_commentaire.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fenetre1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fenetre1ToolStripMenuItem
            // 
            this.fenetre1ToolStripMenuItem.Name = "fenetre1ToolStripMenuItem";
            this.fenetre1ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fenetre1ToolStripMenuItem.Text = "Stats";
            // 
            // tableLayoutPanel_dernier_commentaire
            // 
            this.tableLayoutPanel_dernier_commentaire.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel_dernier_commentaire.ColumnCount = 2;
            this.tableLayoutPanel_dernier_commentaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_dernier_commentaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_dernier_commentaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_dernier_commentaire.Controls.Add(this.label1, 0, 0);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auteur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label_dernier_commentaire.Size = new System.Drawing.Size(205, 18);
            this.label_dernier_commentaire.TabIndex = 2;
            this.label_dernier_commentaire.Text = "Le dernier commentaire posté";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Auteur,
            this.vendeur});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 277);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            // 
            // vendeur
            // 
            this.vendeur.HeaderText = "Sur le profil de";
            this.vendeur.Name = "vendeur";
            // 
            // Commentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_dernier_commentaire);
            this.Controls.Add(this.tableLayoutPanel_dernier_commentaire);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Commentaire";
            this.Text = "Commentaire";
            this.Load += new System.EventHandler(this.Commentaire_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel_dernier_commentaire.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fenetre1ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_dernier_commentaire;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_commentaire;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_dernier_commentaire;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendeur;
    }
}