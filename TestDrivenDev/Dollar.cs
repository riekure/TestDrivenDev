using System;

namespace TestDrivenDev
{
    public class Dollar : Money
    {
        public Dollar(int amoount)
        {
            amount = amoount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}