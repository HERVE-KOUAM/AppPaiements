using AppPaiements;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        // creation d'instances de carte 

        CarteCredit carte1 = new CarteCredit(numeroCarte: 001, description : "Debit",  montant : 12500);
        CarteCredit carte2 = new CarteCredit(numeroCarte: 002, description : "credit", montant: -10500);

        // Creation des instances paypal
        Console.WriteLine("--------------------------------------------------");

        Paypal account1 = new Paypal(couriel: "kouamherve@gmail.com", descrition: "compte principal", montant: 75000);

        Paypal account2 = new Paypal(couriel: "kouamherve145@gmail.com", descrition: "compte secondaire", montant: 50000);

        // ---------------- debut du menu -------------

        Console.WriteLine("bonjour, lisez et suivez les etapes attentivement ");

           // entrez du nom par lutisateur 

        Console.WriteLine(" -- veuiller entrer votre nom : ");

        string nom = Console.ReadLine();


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