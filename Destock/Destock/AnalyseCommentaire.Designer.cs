namespace Destock
{
    partial class AnalyseCommentaire
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_etat_chargement = new System.Windows.Forms.Label();
            this.label_etat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(469, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label_etat_chargement
            // 
            this.label_etat_chargement.AutoSize = true;
            this.label_etat_chargement.Location = new System.Drawing.Point(12, 39);
            this.label_etat_chargement.Name = "label_etat_chargement";
            this.label_etat_chargement.Size = new System.Drawing.Size(67, 13);
            this.label_etat_chargement.TabIndex = 1;
            this.label_etat_chargement.Text = "Chargement:";
            // 
            // label_etat
            // 
            this.label_etat.AutoSize = true;
            this.label_etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_etat.Location = new System.Drawing.Point(76, 39);
            this.label_etat.Name = "label_etat";
            this.label_etat.Size = new System.Drawing.Size(25, 13);
            this.label_etat.TabIndex = 2;
            this.label_etat.Text = "etat";
            // 
            // AnalyseCommentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.label_etat);
            this.Controls.Add(this.label_etat_chargement);
            this.Controls.Add(this.progressBar1);
            this.Name = "AnalyseCommentaire";
            this.Text = "AnalyseCommentaire";
            this.Load += new System.EventHandler(this.AnalyseCommentaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_etat_chargement;
        private System.Windows.Forms.Label label_etat;
    }
}