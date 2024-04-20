using LanguageExt.ClassInstances;
using LanguageExt.Pipes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Starducks.MainClass;

namespace Starducks
{
    public partial class FormReserveBoissonsView : Form
    {
        public FormReserveBoissonsView()
        {
            InitializeComponent();
        }

        private void BTDéconnexion_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        private void BTAccueil_Click(object sender, EventArgs e)
        {
            new FormReserveBoissons().Show();
            this.Close();
        }

        private void BTVoirBoissons_Click(object sender, EventArgs e)
        {

            Boissons.VoirLesBoissons(this.dataGridView1); // Récupére les information qui se trouve dans la fonctions VoirLesBoissons()
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {

            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string nom = selectedRow.Cells["nom"].Value.ToString();
            int prix = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["prix"].Value);

            DialogResult dialogResult = MessageBox.Show("Voulez-vous réserver " + nom + " au prix de " + prix + " ?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Boissons.ReserverBoissons(DateTime.Now, prix, DialogResult);
                MessageBox.Show("Votre réservation de la boisson " + nom + " pour le " + DateTime.Now + " a été effectuée.");
            }
            else
            {
                MessageBox.Show("Réservation annulée.");
            }

        }
    }
}
