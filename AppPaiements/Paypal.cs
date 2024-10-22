using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal: Paiement
    {
        public string Couriel { get; set; }

        public Paypal (string couriel ,string descrition ,double montant) : base (montant , descrition )
        {
            Couriel = couriel;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($" votre paypal : {Couriel} a un montant de : {Montant} , Description {Description}");
        }
    }
}
