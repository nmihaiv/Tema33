using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema33
{
    class Program
    {
        static void Main(string[] args)
        {
            Money myBallance = new Money();
            myBallance.Amount = 20;
            myBallance.Currency = "EUR";

            BankAccount myAccount = new BankAccount();
            myAccount.Ballance = myBallance;

            myAccount.PrintCurrentBalance();

            myAccount.DepositAmount(10);

            myAccount.PrintCurrentBalance();

            myAccount.WithdrawAmount(100);

            myAccount.WithdrawAmount((decimal) 15.5);

            myAccount.PrintCurrentBalance();

            Console.ReadKey();
        }
    }

}
