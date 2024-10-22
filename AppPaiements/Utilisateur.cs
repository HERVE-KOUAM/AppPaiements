using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string nom {  get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom)
        
        {
             string Nom = nom;
             Paiements = new List<Paiement>();
        
        }
        public void AfficherInfo()
        {
            Console.WriteLine($"nom....{nom}... ");
            Console.WriteLine($"Liste de vos paiement :");
            foreach (Paiement p in Paiements)
            {
                Console.Write("---");
                    p.AfficherDetails();
            }
        }
    }
}
