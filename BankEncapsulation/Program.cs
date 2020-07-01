using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount userBankAccount = new BankAccount();
            Console.WriteLine("Please enter your name:");
            userBankAccount.name = Console.ReadLine();
            Console.WriteLine($"Hello, {userBankAccount.name} what can i assist you with today?");
            string[] options = { "Get Balance", "Make a deposit" };
            foreach(string choice in options)
            {
                Console.WriteLine(choice);
            }
            options[0] = "1";
            options[1] = "2";
            Console.WriteLine("Please select an option using 1 for get balance and 2 for deposit:");
            var custChoice = Console.ReadLine();
            if (custChoice == options[0])
            {
                Console.WriteLine(userBankAccount.GetBalance());
            }
            else if (custChoice == options[1])
            {
                Console.WriteLine("How much would you like to deposit?");
                var total = double.Parse(Console.ReadLine());
                userBankAccount.Deposit(total);
                Console.WriteLine($"After your deposit of {total}, your new balace is {userBankAccount.Balance}");
                           
            }
            else
            {
                Console.WriteLine("Have a great day!");
            }
        }
    }
}
