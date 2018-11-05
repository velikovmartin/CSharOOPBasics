using System;
using System.Collections.Generic;

namespace BankAccount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();

            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split();
                var cmdType = cmdArgs[0];

                switch (cmdType)
                {
                    case "Create":
                        acc.Create(cmdArgs, accounts);
                        break;
                    case "Deposit":
                        acc.Deposit(cmdArgs, accounts);
                        break;
                    case "Withdraw":
                        acc.Withdraw(cmdArgs, accounts);
                        break;
                    case "Print":
                        acc.Print(cmdArgs, accounts);
                        break;
                }
            }
        }
    }
}
