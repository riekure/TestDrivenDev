using System;

namespace TestDrivenDev
{
    public class Dollar : Money
    {
        public Dollar(int amoount)
        {
            amount = amoount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}