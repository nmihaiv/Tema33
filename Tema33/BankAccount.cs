namespace Tema33
{
    public class BankAccount
    {
        public Money Ballance { get; set; }

        public bool HasPositiveBalance()
        {
            if (Ballance.Amount > 0)
                return true;
            return false;
           
        }

        public bool HasEnoughAmount(decimal amount)
        {
            if (Ballance.Amount > amount)
                return true;
            else
            return false;
        }

        public void DepositAmount(decimal amount)
        {
            Ballance.Amount += amount;
        }

        public void WithdrawAmount(decimal amount)
        {
            if(HasEnoughAmount(amount))
                Ballance.Amount -= amount;
            else
                System.Console.WriteLine("Contul nu dispune de {0} {1}", amount, Ballance.Currency);
        }

        public void PrintCurrentBalance()
        {
            System.Console.WriteLine("In acest moment aveti: {0}", Ballance.GetAmountWithCurrency());
        }
    }
}
