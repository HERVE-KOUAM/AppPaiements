using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(int numeroCarte , string description ,double montant) : base( montant, description)
        {
            NumeroCarte = numeroCarte;
        }

       
        public override void AfficherDetails()
        {
            Console.WriteLine($" numero carte  : {NumeroCarte} Descrition : { Description} , Montant {Montant} ");

            
        }
    }
}
