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
            this.label_id_annonce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id_annonce
            // 
            this.label_id_annonce.AutoSize = true;
            this.label_id_annonce.Location = new System.Drawing.Point(41, 23);
            this.label_id_annonce.Name = "label_id_annonce";
            this.label_id_annonce.Size = new System.Drawing.Size(13, 13);
            this.label_id_annonce.TabIndex = 0;
            this.label_id_annonce.Text = "0";
            // 
            // DetailsAnnonce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_id_annonce);
            this.Name = "DetailsAnnonce";
            this.Text = "DetailsAnnonce";
            this.Load += new System.EventHandler(this.DetailsAnnonce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id_annonce;
    }
}