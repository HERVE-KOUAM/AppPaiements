using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom)

        {
            Nom = nom;
            Paiements = new List<Paiement>();

        }
        public void AfficherInfo()
        {
            Console.WriteLine($"nom....{Nom}... ");
            Console.WriteLine($"Liste de vos paiement :");
            foreach (Paiement p in Paiements)
            {
                Console.Write("---");
                p.AfficherDetails();
            }
        }

        public void AjouterPaiement (Paiement paiement){


            Paiements.Add(paiement);


        }
    }
}
