using System;

namespace TestDrivenDev
{
    public class Frunc
    {
        private int amount;

        public Frunc(int amount)
        {
            this.amount = amount;
        }

        public Frunc Times(int multiplier)
        {
            return new Frunc(amount * multiplier);
        }
        
        public override bool Equals(object obj)
        {
            Frunc frunc = (Frunc) obj;
            return amount == frunc.amount;
        }
    }
}