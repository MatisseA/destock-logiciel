using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destock
{
    public partial class Statistique : Form
    {
        FormPrincipale lien;
        public Statistique(FormPrincipale lien2)
        {
            InitializeComponent();
            this.lien = lien2;
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
            statPremiumPourcentage();
        }

        private void statPremiumPourcentage()
        {
            
        }
    }
}
