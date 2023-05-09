using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);

            SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.025m, 1000.0m);

            Console.WriteLine($"Checking balance is{checking.Balance:C2}");
            Console.WriteLine($"Saving balance is{saving.Balance:C2}");

            Console.WriteLine($"Checking owner: {checking.AccountOwner}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");

            checking.Deposit(200.0m);
            saving.Deposit(150.0m);

            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Saving balance is {saving.Balance:C2}");

            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Saving balance is {saving.Balance:C2}");

            Console.ReadKey();
        }
    }
}
