using System;

namespace TestDrivenDev
{
    public class Money : IExpression
    {
        protected int Amount;
        protected string Currency;

        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Money(Amount + addend.Amount, Currency);
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