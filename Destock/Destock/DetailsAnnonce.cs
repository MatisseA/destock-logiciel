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
    public partial class DetailsAnnonce : Form
    {
        String idAnnonce;
        public DetailsAnnonce(String idAnnonce)
        {
            InitializeComponent();
            this.idAnnonce = idAnnonce;
        }

        private void DetailsAnnonce_Load(object sender, EventArgs e)
        {
            label_id_annonce.Text = this.idAnnonce;
        }
    }
}
