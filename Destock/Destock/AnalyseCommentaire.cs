using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destock
{
    public partial class AnalyseCommentaire : Form
    {
        FormPrincipale lien;
        public AnalyseCommentaire(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        public struct unMot
        {
            public String mot;
        }

        private void AnalyseCommentaire_Load(object sender, EventArgs e)
        {
            addListWord();
        }

        private void addListWord()
        {
            label_etat.Text = "Création de la liste de mot indésirable";
            const string fileName = "bad-words.txt";
            List<string> lines = new List<string>();

            // Use using-keyword for disposing.
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Use while not null pattern in while loop.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            // Print out all the lines in the list.
            foreach (string value in lines)
            {
                progressBar1.Value++;
            }
        }

        private void rechercheDansCommentaire(String lemot)
        {

        }
    }
}
