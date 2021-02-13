namespace Tema33
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public string GetAmountWithCurrency()
        {
            return Amount + " " + Currency ;
        }

        public void MultiplyAmount(int factor)
        {
            Amount *= factor;
        }
    }
}
