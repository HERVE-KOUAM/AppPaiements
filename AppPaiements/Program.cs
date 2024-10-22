using AppPaiements;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        // creation d'instances de carte 

        CarteCredit carte1 = new CarteCredit(numeroCarte: 001, description : "Debit",  montant : 12500);
        CarteCredit carte2 = new CarteCredit(numeroCarte: 002, description : "credit", montant: -10500);
        CarteCredit carte3 = new CarteCredit(numeroCarte: 003, description: "credit", montant: -20000);


        // affichage a lecran des cartes

        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();

        // Creation des instances paypal

        Paypal account1 = new Paypal(couriel: "kouamherve@gmail.com", descrition: "compte principal", montant: 75000);

        Paypal account2 = new Paypal(couriel: "kouamherve145@gmail.com", descrition: "compte secondaire", montant: 50000);

        // affichage a lecran des compte paypal

        account1.AfficherDetails();
        account2.AfficherDetails();


    }
}