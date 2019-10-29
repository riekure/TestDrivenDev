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
            return new Sum(this, added);
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).Amount + addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IExpression Times(int multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }
    }
}