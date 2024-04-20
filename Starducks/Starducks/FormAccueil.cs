using LanguageExt.Pipes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Starducks.MainClass;

namespace Starducks
{
    public partial class FormAccueil : Form
    {
        string user = Session.GetUsername();
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTBoissons_Click(object sender, EventArgs e)
        {
            new FormBoissons().Show();
            this.Hide();
        }

        private void LBId_Click(object sender, EventArgs e)
        {
            // **Connexion à la base de données**
            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;
            MySqlCommand Query = new MySqlCommand($"SELECT user FROM user WHERE user = {user} AND mdp = {Session.GetMdpuser()}", conn);
            MySqlDataReader Reader = Query.ExecuteReader();

            while (Reader.Read())
            {
                LBId.Text = Reader.GetString(0);
            }
            

        }

        private void BTDéconnexion_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Close();
        }
    }
}
