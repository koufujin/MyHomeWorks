namespace TMS_HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard("Alex","Krasniakou"); 
            CreditCard creditCard1 = new CreditCard("Morgan", "Freeman");
            CreditCard creditCard2 = new CreditCard("Denzel", "Washington");

            creditCard.CreateCardNumber();
            creditCard.ShowAccountStatus();
            creditCard1.ShowAccountStatus();
            creditCard1.CreateCardNumber();
            creditCard2.CreateCardNumber();
            creditCard1.ShowAccountStatus();
            creditCard.TakeCash(15);
            creditCard.AddCash(100);
            creditCard.TakeCash(50);
            creditCard.ShowAccountStatus();


            Console.ReadLine();
        }
    }
}
