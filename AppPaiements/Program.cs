using AppPaiements;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

        // entrez des informations  par lutisateur 

        Console.WriteLine(" -- veuiller entrer votre nom : ");

        string nom = Console.ReadLine();

        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("-- Entrez votre couriel");

        

        string mail = Console.ReadLine();
        // creation d'instances de carte 

        CarteCredit carte1 = new CarteCredit(numeroCarte: 001, description : "porche Ca",  montant : 650000);
        CarteCredit carte2 = new CarteCredit(numeroCarte: 002, description : "E-Transfert", montant: 150000);

        // Creation des instances paypal
        Console.WriteLine("--------------------------------------------------");

        Paypal account1 = new Paypal(couriel: mail , descrition: "MSI CA ", montant: 8000);

        Paypal account2 = new Paypal(couriel: mail, descrition: "Amazone CA", montant: 50000);

        // ---------------- debut du menu -------------

        Console.WriteLine("bonjour, lisez et suivez les etapes attentivement ");




        // affichage a lecran des cartes

        Console.WriteLine(" Historique de payement ");

        Console.WriteLine("......................................................");

        Console.WriteLine("--------------------------------------------------");

        Utilisateur USER = new Utilisateur(nom);

        // affichage a lecran des cartes
        USER.AjouterPaiement(carte1);
        USER.AjouterPaiement(carte2);
        // affichage a lecran des compte paypal
        USER.AjouterPaiement(account1);
        USER.AjouterPaiement(account2 );

        Console.WriteLine("--------------------------------------------------");
        USER.AfficherInfo();
    }
}