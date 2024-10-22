using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        public double Montant { get; set; }
        public string Description { get; set; }

        // creation du constructeur 

        public Paiement(double montant, string descrition)
        {
            Montant = montant;
            Description = descrition;
        }

        // creation de la methode 
        public virtual void AfficherDetails()

        {
            Console.WriteLine("");
            Console.WriteLine($" Montant : {Montant}, Description {Description} .......");
        }

    }


}