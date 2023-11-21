using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_part_1
{
    internal class Program

    {

        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("jambu");
            myAccount.Deposit(100000);
            myAccount.Withdraw(500);
            Console.WriteLine($"account Number:{myAccount.AccountNumber}");
            Console.WriteLine($"account Holder:{myAccount.AccountHolderName}");
            Console.WriteLine($"account balance:{myAccount.Balance}");
            Console.ReadKey();


        }
    }
}
