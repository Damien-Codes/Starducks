using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starducks
{
    public partial class FormReserveBoissons : Form
    {
        public FormReserveBoissons()
        {
            InitializeComponent();
        }

        private void BTAccueil_Click(object sender, EventArgs e)
        {
            new FormAccueil().Show();
            this.Hide();
        }

        private void BTBoissons_Click(object sender, EventArgs e)
        {
            new FormReserveBoissonsView().Show();
            this.Hide();
        }

        private void lBIdV_Click(object sender, EventArgs e)
        {

        }

        private void BTDéconnexion_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }
    }
}
