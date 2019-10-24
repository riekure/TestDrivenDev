using System.Net.Configuration;

namespace TestDrivenDev
{
    public class Sum : IExpression
    { 
        
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Amount + addend.Amount;
            return new Money(amount, to);
        }
    }
}