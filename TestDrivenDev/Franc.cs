using System;
using System.Security.Permissions;

namespace TestDrivenDev
{
    public class Franc : Money
    {
        public Franc(int amount, string currency):base(amount, currency)
        {
        }
    }
}