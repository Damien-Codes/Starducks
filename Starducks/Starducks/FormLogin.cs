using MySqlX.XDevAPI;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BTConnexion_Click(object sender, EventArgs e)
        {

            char typeU = AppliBD.ConnexionU(textBox1.Text, textBox2.Text);
            if (typeU == 'I')
            {
                // Si le motdepasse et/ou le user et affiche un MessageBox
                MessageBox.Show("Identifiants incorrects, réessayez.");
            }
            else if (typeU == 'R')
            {
                Session.SetTypeU(typeU);
                new FormAccueil().Show();
                Session.SetformConnexion(this);
                // Cache la fenêtre Connexion
                this.Hide();
            }
            else
            {
                Session.SetTypeU(typeU);
                new FormReserveBoissons().Show();
                Session.SetformConnexion(this);
                // Cache la fenêtre Connexion
                this.Hide();
            }
            // Met en Session la textBox1 et la textBox2 dans une variable Session
            Session.SetUsername(textBox1.Text);
            Session.SetPassword(textBox2.Text);
        }

        private void BTQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
