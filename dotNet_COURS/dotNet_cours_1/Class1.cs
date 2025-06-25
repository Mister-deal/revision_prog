using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_cours_1
{
    public class Livre
    {
       public string titre
        {
            get;
            set;
        }
        public string auteur
        {
            get;
            set;
        }
        public int annee
        {
            get;
            set;
        }
        public Livre(string titre, string auteur, int annee)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.annee = annee;
        }
    }
}
