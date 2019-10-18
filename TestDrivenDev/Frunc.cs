using System;

namespace TestDrivenDev
{
    public class Frunc : Money
    {
        public Frunc(int amount)
        {
            this.amount = amount;
        }

        public Frunc Times(int multiplier)
        {
            return new Frunc(amount * multiplier);
        }
    }
}