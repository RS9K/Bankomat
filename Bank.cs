using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Bankomat
{
    public class Bank
    {
        public Account[] accounts = new Account[11];
        public Bank()
        {
            for (int i = 1; i <= 10; i++)
            {
                accounts[i] = new Account(i, 0);
            }
        }

        public void ListOfAccounts()
        {
            Console.WriteLine("List of Accounts: ");
            foreach (var account in accounts)
            {
                if (account != null)
                {
                    Console.WriteLine($" Account ID: {account.AccountID}, Balance: {account.AccountBalance}");
                }
            }
        }

        public void MainMenu()
        {
            Console.WriteLine("Hi! Please type in your ID (1-10)");
            int accountChoice = int.Parse(Console.ReadLine());
            if (accountChoice < 1 || accountChoice > 10)
            {
                Console.WriteLine("There is only 10 accounts. Please pick between 1-10");
                MainMenu();
                return;
            }
            AccountMenu(accountChoice);
        }
        public void AccountMenu(int accountChoice)
        {
            Console.WriteLine($"ID nr:{accountChoice}. Please pick an option:");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4.Show list of accounts");
            Console.WriteLine("5. Exit");
            int Choice2 = int.Parse(Console.ReadLine());

            switch (Choice2)
            {
                case 1:
                    Console.WriteLine("Enter amount to withdraw:");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    accounts[accountChoice].Withdraw(withdrawAmount);
                    AccountMenu(accountChoice);
                    break;
               
                case 2:
                    Console.WriteLine("Enter amount:");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    accounts[accountChoice].Deposit(depositAmount);
                    Console.WriteLine("Deposit successful!");
                    AccountMenu(accountChoice);
                    break;
                
                case 3:
                    accounts[accountChoice].ShowBalance();
                    AccountMenu(accountChoice);
                    break;

                case 4:
                    ListOfAccounts();
                    AccountMenu(accountChoice);
                    break;

                case 5:
                    Console.WriteLine("Have a good day!");
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Pick between the available options");
                    AccountMenu(accountChoice);
                    break;
            }

        }
    }

}
