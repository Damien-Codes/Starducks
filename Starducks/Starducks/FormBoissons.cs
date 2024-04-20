using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static Starducks.MainClass;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Starducks
{
    public partial class FormBoissons : Form
    {
        private void BTAccueil_Click(object sender, EventArgs e)
        {
            new FormAccueil().Show();
            this.Hide();
        }
        public FormBoissons()
        {
            InitializeComponent();
        }


        private void BTDéconnexion_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }

        string imgLocation = "";
        private void btnUploadImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers image (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Tous les fichiers (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
        private void BTAjout_Click(object sender, EventArgs e)
        {
            Boissons boissons = new Boissons(0, "boissons", 15, "image.jpg");
            byte[] imageBytes = null;

            using (var ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }

            Boissons.InsertBoissons(TBNom.Text, TBPrix.Text, imageBytes);
            MessageBox.Show(" Donnees sauvegarder avec succès !");

        }


        private void BTVoirBoissons_Click(object sender, EventArgs e)
        {
            Boissons.VoirLesBoissons(this.dataGridView1); // Récupére les information qui se trouve dans la fonctions VoirLesBoissons()
        }


        private void BTModifier_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Retrieve the numboissons value from the selected row
            int numboissons = int.Parse(selectedRow.Cells["Id"].Value.ToString());

            // Check if an image has been selected
            byte[] imageBytes = null;
            if (pictureBox1.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
            }

            Boissons.ModifierBoissons(numboissons, TBNom.Text, TBPrix.Text, imageBytes);
            MessageBox.Show("Données Modifier avec succès !");
        }

        private void FormBoissons_Load(object sender, EventArgs e)
        {
            // **Connexion à la base de données**
            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;

            string Query = "SELECT numboissons, nom, prix, imageboissons FROM boissons";
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TBNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TBPrix.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pictureBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BTSupprimer_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Retrieve the numboissons value from the selected row
            int numboissons = int.Parse(selectedRow.Cells["Id"].Value.ToString());

            Boissons.SupprimerBoissons(numboissons);
        }
    }
}