using Google.Protobuf.WellKnownTypes;
using LanguageExt.ClassInstances;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Starducks.MainClass;

namespace Starducks
{
    internal class Boissons
    {
        private string nom;
        private int prix;
        private Image imageboissons;

        public Boissons(string nom, int prix, Image imageboissons)
        {
            this.nom = nom;
            this.prix = prix;
            this.imageboissons = imageboissons;
        }
        public void setNom(string nom) { 
            this.nom = nom;
        }
        public string getNom()
        {
            return this.nom;
        }
        public void setPrix(int prix)
        {
            this.prix = prix;
        }
        public int getPrix()
        {
            return this.prix;
        }
        public void setImageboissons(Image imageboissons)
        {
            this.imageboissons = imageboissons;
        }
        public Image getImageboissons()
        {
            return this.imageboissons;
        }

        public void Insertboissons(string nom, int prix, string imageboissons)
        {
            //AppliBD.ConnexionBD();
            //MySqlConnection conn = AppliBD.conn;


            //string sqlQuery = "INSERT INTO boissons(nom, prix, imageboissons) VALUES(@nom, @prix, @images)";
            //MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            //cmd.Parameters.AddWithValue("@nom", nom);
            //cmd.Parameters.AddWithValue("@prix", prix);
            //cmd.Parameters.AddWithValue("@images", imageboissons);

            //cmd.ExecuteNonQuery();
            //conn.Close();
            //MessageBox.Show(" Donnees sauvegarder...!");
        }

    }
}
