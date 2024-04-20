using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starducks
{
    public static class Session
    {
        private static FormLogin formconn;
        private static char typeU;
        private static string username;
        private static string password;

        public static void SetTypeU(char ntypeU)
        {
            Session.typeU = ntypeU;
        }

        public static void SetformConnexion(FormLogin nouvformConnexion)
        {
            Session.formconn = nouvformConnexion;
        }

        public static void SetformDeconnxion(FormLogin nouvformConnexion)
        {
            Session.formconn = nouvformConnexion;
        }
        public static void SetUsername(string username)
        {
            Session.username = username;
        }
        public static string GetUsername()
        {
            return Session.username;
        }
        public static void SetPassword(string password)
        {
            Session.password = password;
        }
        public static string GetMdpuser()
        {
            return Session.password;
        }
    }
}
