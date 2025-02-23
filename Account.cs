using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Bankomat
{
    public class Account
    {
        public int AccountID { get; set; }
        public decimal AccountBalance { get; set; }

        public Account (int accountID, decimal accountBalance)
        {
            AccountID = accountID;
            AccountBalance = accountBalance;
        }

        public void Withdraw(decimal amount)
        {
            AccountBalance -= amount;
            if (AccountBalance < 0) 
            {
                Console.WriteLine("You don't have enough funds for this withdrawal!");
                return;
            }
            else
            {
                Console.WriteLine("Withdrawal successful!");
                return ;
            }
        }

        public void Deposit(decimal amount)
        {
            AccountBalance += amount;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"The balance in Account {AccountID} is: {AccountBalance}");
        }
    }
}
