using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval2LYJ
{
    internal class Don
    {
        private String donateur;
        private int montant;

        public String Donateur() { return donateur; }
        public int Montant() { return montant; }

       public Don(String nom, int valeur)
        {
            donateur = nom;
            montant = valeur;
        }
    }
}
