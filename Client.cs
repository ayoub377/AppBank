using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBank
{
    class client
    {
        string nom;
        string prenom;
        string adresse;

        public client(string nm, string prnm, string adr)
        {
            this.nom = nm;
            this.prenom = prnm;
            this.adresse = adr;
        }

        public client(client c)
        {
            this.nom = c.nom;
            this.prenom = c.prenom;
            this.adresse = c.adresse;
        }



        public void afficher()
        {
            Console.WriteLine("nom:" + this.nom + "\t" + "prenom" + this.prenom + "\t" + "adresse:" + "\t" + this.adresse);
        }


    }
}
