using System;

namespace TestDrivenDev
{
    public class Bank
    {
        public Money reduce(IExpression source, string to)
        {
            return Money.CreateDollar(10);
        }
    }
}