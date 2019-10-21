using System;

namespace TestDrivenDev
{
    public abstract class Money
    {
        protected int Amount;
        protected string Currency;

        public Money(int amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }
        
        public abstract Money Times(int multiplier);

        public string GetCurrency()
        {
            return Currency;
        }
        
        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && GetType() == money.GetType();
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