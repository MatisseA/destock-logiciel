namespace Destock
{
    partial class Statistique
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistique));
            this.graphique = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_choix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_générer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphique)).BeginInit();
            this.SuspendLayout();
            // 
            // graphique
            // 
            this.graphique.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.graphique.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.Title = "Légende:";
            this.graphique.Legends.Add(legend1);
            this.graphique.Location = new System.Drawing.Point(12, 12);
            this.graphique.Name = "graphique";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.graphique.Series.Add(series1);
            this.graphique.Series.Add(series2);
            this.graphique.Size = new System.Drawing.Size(759, 174);
            this.graphique.TabIndex = 0;
            this.graphique.Text = "chart1";
            title1.Name = "titre_graphique";
            title1.Text = "Titre";
            this.graphique.Titles.Add(title1);
            // 
            // comboBox_choix
            // 
            this.comboBox_choix.FormattingEnabled = true;
            this.comboBox_choix.Items.AddRange(new object[] {
            "Pourcentage d\'annonces premium",
            "Nombre total d\'annonce en ligne"});
            this.comboBox_choix.Location = new System.Drawing.Point(12, 252);
            this.comboBox_choix.Name = "comboBox_choix";
            this.comboBox_choix.Size = new System.Drawing.Size(214, 21);
            this.comboBox_choix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choix du graphique";
            // 
            // button_générer
            // 
            this.button_générer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_générer.Location = new System.Drawing.Point(695, 445);
            this.button_générer.Name = "button_générer";
            this.button_générer.Size = new System.Drawing.Size(75, 23);
            this.button_générer.TabIndex = 3;
            this.button_générer.Text = "Générer";
            this.button_générer.UseVisualStyleBackColor = true;
            this.button_générer.Click += new System.EventHandler(this.button_générer_Click);
            // 
            // Statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(783, 480);
            this.Controls.Add(this.button_générer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_choix);
            this.Controls.Add(this.graphique);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistique";
            this.Load += new System.EventHandler(this.Statistique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphique;
        private System.Windows.Forms.ComboBox comboBox_choix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_générer;
    }
}