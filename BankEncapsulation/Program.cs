namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount main = new BankAccount();

            Console.WriteLine($"Welcome. Please determine how much you would like to deposit.");
            double deposit = int.Parse(Console.ReadLine());
            main.Deposit(deposit);
            Console.WriteLine($"You now have ${main.GetBalance()} in your account.");
        }
    }
}
