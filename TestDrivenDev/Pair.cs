using System;
using System.Security.AccessControl;

namespace TestDrivenDev
{
    public class Pair
    {
        private string From;
        private string To;

        public Pair(string from, string to)
        {
            this.From = from;
            this.To = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair) obj;
            return From.Equals(pair.From) && To.Equals(pair.To);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}