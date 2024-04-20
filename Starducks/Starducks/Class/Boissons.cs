using Google.Protobuf.WellKnownTypes;
using LanguageExt.ClassInstances;
using LanguageExt.TypeClasses;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Starducks.MainClass;
using System.ComponentModel.Design;

namespace Starducks
{
    public class Boissons
    {
        private int numboissons;
        private string nom;
        private int prix;
        private string imageboissons;
        // J'assigne une List<Boisson> qui stockée dans brevetage
        private static List<Boissons> brevetage = new List<Boissons>();
        private static DataGridView dataGridView1;

        public Boissons(int numboissons, string nom, int prix, string imageboissons)
        {
            this.numboissons = numboissons;
            this.nom = nom;
            this.prix = prix;
            this.imageboissons = imageboissons;
        }
        public void setNumboissons(int numboissons) { this.numboissons = numboissons; }
        public int getNumboissons() { return this.numboissons; }
        public void setNom(string nom) { this.nom = nom; }
        public string getNom() { return this.nom; }
        public void setPrix(int prix) { this.prix = prix; }
        public int getPrix() { return this.prix; }
        public void setImageboissons(string imageboissons) { this.imageboissons = imageboissons; }
        public string getImageboissons() { return this.imageboissons; }
        public static List<Boissons> getBrevetage() { return brevetage; }

        public override string ToString()
        {
            // Déclaration d'une variable pour stocker la représentation textuelle de l'objet
            string str = "";

            // Ajout des propriétés de l'objet à la chaîne de caractères
            str += "Nom: " + this.getNom() + "\n";
            str += "Prix: " + this.getPrix() + "\n";

            // Retourne la chaîne de caractères
            return str;
        }

        public static void LesBoissons()
        {
            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;

            string sqlQuery = "SELECT numboissons, nom, prix, imageboissons FROM boissons";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            while(rdr.Read() != null){
                // Ajoute les valeur qui se trouve dans la base de données et la stocke dans la 
                // List<Boissons> qui est stockée dans brevetage
                brevetage.Add(new Boissons(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(3)));
            }
            conn.Close();
        }

        public static void VoirLesBoissons(DataGridView dataGridView) // Receive DataGridView as a parameter
        {
            // -------- Solutions 1 -----------------
            //AppliBD.ConnexionBD();
            //MySqlConnection conn = AppliBD.conn;

            //string sqlQuery = "SELECT numboissons, nom, prix, imageboissons FROM boissons";
            //MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //rdr.Read();
            //while (rdr.Read())
            //{
            //        dt.Rows.Add(new Boissons(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(3)));
            //}
            //dataGridView.DataSource = dt; // Set the data source of the passed DataGridView
            //conn.Close();

            // -------------------- Solutions 2 -----------------

            if (dataGridView != null)
            {
                AppliBD.ConnexionBD();
                MySqlConnection conn = AppliBD.conn;

                string sqlQuery = "SELECT numboissons, nom, prix, imageboissons FROM boissons";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    // Ajoutez des colonnes à DataTable en fonction des données récupérées
                    dt.Columns.Add("Id", typeof(int)); // Ajoute l'Id dans la DataTable (Datagrid)
                    dt.Columns.Add("nom", typeof(string)); // Ajoute le nom dans la DataTable (Datagrid)
                    dt.Columns.Add("prix", typeof(int)); // Ajoute le prix dans la DataTable (Datagrid)
                    dt.Columns.Add("imageboissons", typeof(string)); // Ajoute le imageboissons dans la DataTable (Datagrid)

                    while (rdr.Read())
                    {   // Ajoute une nouvelle ligne à la table de données "dt"
                        dt.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(3));
                    }
                    dataGridView.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur de connection: " + ex.Message);
                }
            }
        }

        public static void InsertBoissons(string nom, string prix, byte[] imageboissons)
        {
            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;

            string sql = "INSERT INTO boissons(nom, prix, imageboissons) VALUES ('" + nom + "', '" + prix + "', '" + imageboissons + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ModifierBoissons(int numboissons, string nom, string prix, byte[] imageboissons)
        {
            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;

            string sql = "UPDATE boissons SET nom = '" + nom + "', prix = '" + prix + "', imageboissons = '" + imageboissons + "' WHERE numboissons = @numboissons;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@numboissons", numboissons);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void SupprimerBoissons(int numboissons)
        {
            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;

            // Prepare the SQL statement
            string sql = "DELETE FROM boissons WHERE numboissons = @numboissons;";

            // Create a MySqlCommand object
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Add parameter
            cmd.Parameters.AddWithValue("@numboissons", numboissons);

            // Execute the command
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Boisson supprimée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de la boisson : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // fonction pour réserver une boissons pour les vacanciers
        public static void ReserverBoissons(DateTime date, int prix, DialogResult dialogResult)
        {

            AppliBD.ConnexionBD();
            MySqlConnection conn = AppliBD.conn;

            
            DateTime Date = DateTime.Now; // Date d'aujourd'hui

            
            string sqlQuery = "INSERT INTO commande(datecom, user, prix) VALUES(@datecom, @user, @prix)";
            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
            command.Parameters.AddWithValue("@datecom", Date);
            command.Parameters.AddWithValue("@user", Session.GetUsername());
            command.Parameters.AddWithValue("@prix", prix);
            
            command.ExecuteNonQuery();
            conn.Close();









            //// **Connexion à la base de données**
            //AppliBD.ConnexionBD();
            //MySqlConnection conn = AppliBD.conn;


            //string Query = "SELECT nom FROM boissons";
            //MySqlCommand cmd = new MySqlCommand(Query, conn);

            //DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            //// Accéder à la cellule contenant le nom
            //string nomBoisson = selectedRow.Cells["nom"].Value.ToString();

            //DialogResult dialogResult = MessageBox.Show("Voulez vous réserver la boisson " + nomBoisson + " ?", "", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    //string query = $"INSERT INTO  commande (datecom, user, prix) VALUES ( CAST(NOW() AS DATE), {Session.GetUsername()}, {dataGridView1.SelectedRows[0]});";
            //    //MySqlCommand cmd = new MySqlCommand(query, conn);

            //    // Execution de la requête
            //    //MySqlDataReader rdr = cmd.ExecuteReader();
            //    DateTime date = DateTime.Now; // Date d'aujourd'hui

            //    string sqlQuery = "INSERT INTO commande(datecom, user, prix) VALUES(@datecom, @user, @prix)";
            //    MySqlCommand command = new MySqlCommand(sqlQuery, conn);
            //    cmd.Parameters.AddWithValue("@datecom", date);
            //    cmd.Parameters.AddWithValue("@user", Session.GetUsername());
            //    cmd.Parameters.AddWithValue("@prix", dataGridView1.SelectedRows[0]);

            //    cmd.ExecuteNonQuery();
            //    conn.Close();

            //    MessageBox.Show("Votre réservation de la boisson " + nomBoisson + " pour le " + date + " a été effectuée.");
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("Choisissez  une valeur dans !");
            //}
        }
    }
}