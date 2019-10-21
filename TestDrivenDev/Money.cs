using System;

namespace TestDrivenDev
{
    public class Money
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
        
        public static Dollar CreateDollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc CreateFranc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}