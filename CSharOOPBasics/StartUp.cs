using System;

namespace BankAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount
            {
                Id = 1,
                Balance = 15
            };

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}
