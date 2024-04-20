using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Starducks
{
    internal class MainClass
    {
        public static class AppliBD
        {
            public static MySqlConnection conn = null;
            // Créer une Fonction qui se connecte a la base de données
            public static bool ConnexionBD()
            {
                //Récupérer les information de la base de données écrit dans les properties
                conn = new MySqlConnection(Properties.Settings.Default.Connexion);
                //Ouvrir la base de données
                conn.Open();
                //Faire une condition pour savoir si la BDD est connecté
                // Si l'etat de la conneixon (conn) == System.Data.ConnectionState.Open
                // Afficher True sinom False
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    // retourne Vrai
                    return true;
                }
                else
                {
                    // retourne Faux
                    return false;
                }
            }
            // Créer une Fonction pour déterminer le type d'utilisateur à partir de son nom d'utilisateur et mot de passe
            public static char ConnexionU(string usern, string motdepasse)
            {
                // Déclaration de la variable pour stocker le type d'utilisateur
                char typeUtilisateur = 'I';
                // Appel la fonctions ConnexionBD() réaliser plus haut
                ConnexionBD();
                // Création d'une commande SQL
                MySqlCommand cmd = conn.CreateCommand();
                // Stock une requête SQL dans une variables (query) pour sélectionner le type d'utilisateur en fonction du nom d'utilisateur et du mot de passe
                string query = "SELECT typeuser FROM user WHERE user=@user AND mdp=@mdp;";

                // Affecter la valeur de la variable query à la propriété CommandText de l'objet cmd.
                cmd.CommandText = query;

                // On associe la variable usern (passer en paramètre par l'utilisateur) à @user 
                cmd.Parameters.AddWithValue("@user", usern);
                // On associe la variable motdepasse (passer en paramètre par l'utilisateur) à @user
                cmd.Parameters.AddWithValue("@mdp", motdepasse);

                // Execution de la requête
                MySqlDataReader rdr = cmd.ExecuteReader();

                // Si un utilisateur est trouvé
                if (rdr.Read())
                {
                    // Récupération du type d'utilisateur à partir de la première ligne du résultat
                    typeUtilisateur = rdr.GetChar("typeuser");
                }
                // Fermeture de la base de données
                rdr.Close();
                // Retour du type d'utilisateur
                return typeUtilisateur;
            }
        }
    }
}