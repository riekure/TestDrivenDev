using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace TestDrivenDev
{
    public class Bank
    {
        private  IDictionary<Pair, int> Rates = new Dictionary<Pair, int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            Rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from == to) return 1;
            return Rates[new Pair(from, to)];
        }
    }
}