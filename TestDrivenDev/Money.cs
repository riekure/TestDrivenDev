using System;

namespace TestDrivenDev
{
    public class Money : IExpression
    {
        public int Amount;
        protected string Currency;

        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public IExpression Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        public string GetCurrency()
        {
            return Currency;
        }
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && GetCurrency().Equals(money.GetCurrency());
        }

        public string To_string()
        {
            return Amount + " " + Currency;
        }
        
        public static Money CreateDollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money CreateFranc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}