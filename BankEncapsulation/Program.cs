namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //In the main method of your application,
            //create a new instance of the BankAccount class.
            //Allow the user of the application to Deposit money and retrieve their balance through the console.
            
            BankAccount myAccount = new BankAccount();

            Console.Write("Enter an amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            myAccount.Deposit(amount);

            Console.WriteLine("Deposit successful!");
            Console.WriteLine("Your current balance is: " + myAccount.GetBalance());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
            
            
            
            
            
            
        }
    }
}
