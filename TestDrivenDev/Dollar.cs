using System;

namespace TestDrivenDev
{
    public class Dollar
    {
        private int amount;
        public Dollar(int amoount)
        {
            amount = amoount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar) obj;
            return amount == dollar.amount;
        }
    }
}