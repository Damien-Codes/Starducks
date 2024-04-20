using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starducks
{
    internal class User
    {
        private string user;
        private string mdp;
        private string typeuser;
        private string mailuser;
        private string teluser;

        public User(string user, string mdp, string typeuser, string mailuser, string teluser)
        {
            this.user = user;
            this.mdp = mdp;
            this.typeuser = typeuser;
            this.mailuser = mailuser;
            this.teluser = teluser;
        }
        public void Setuser(string user) { user = user; }
        public string Getuser() { return user; }

        public void Setmdp(string mdp) { mdp = mdp; }
        public string Getmdp() { return mdp; }

        public void Settypeuser(string typeuser) { typeuser =  typeuser; }
        public string Gettypeuser() {  return typeuser; }
        public void SetMailuser(string mailuser) { mailuser = mailuser; }
        public string Getmailuser() {  return mailuser; }
        public void SetTeluser(string teluser) { teluser = teluser.ToLower(); }
        public string Getteluser() {  return teluser; }

        public void afficherId(int id)
        {
            Console.WriteLine(id);
        }
    }
}
