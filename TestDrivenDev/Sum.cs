using System.Net.Configuration;

namespace TestDrivenDev
{
    public class Sum : IExpression
    { 
        
        public IExpression augend;
        public IExpression addend;

        public Sum(IExpression augend, IExpression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public IExpression Plus(IExpression added)
        {
            return null;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }
    }
}