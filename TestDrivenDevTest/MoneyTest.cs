using System;
using System.Diagnostics;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using TestDrivenDev;
using static NUnit.Framework.Assert;

namespace TestDrivenDevTest
{
    [TestFixture]
    public class MoneyTest
    {
        [Test]
        public void TestMultiplication()
        {
            Money five = Money.CreateDollar(5);
            AreEqual(Money.CreateDollar(10), five.Times(2));
            AreEqual(Money.CreateDollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            IsTrue(condition: Money.CreateDollar(5).Equals(Money.CreateDollar(5)));
            IsFalse(Money.CreateDollar(5).Equals(Money.CreateDollar(6)));
            IsFalse(Money.CreateFranc(5).Equals(Money.CreateDollar(5)));
        }

        [Test]
        public void TestCurrency()
        {
            AreEqual("USD", Money.CreateDollar(1).GetCurrency());
            AreEqual("CHF", Money.CreateFranc(1).GetCurrency());
        }

        [Test]
        public void TempSimpleAddition()
        {
            Money five = Money.CreateDollar(5);
            IExpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            AreEqual(Money.CreateDollar(10), reduced);
        }

        [Test]
        public void TestPlusReturnsSum()
        {
            Money five = Money.CreateDollar(5);
            IExpression result = five.Plus(five);
            Sum sum = (Sum) result;
            AreEqual(five, sum.augend);
            AreEqual(five, sum.addend);
        }

        [Test]
        public void TestReduceSum()
        {
            IExpression sum = new Sum(Money.CreateDollar(3), Money.CreateDollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            AreEqual(Money.CreateDollar(7), result);
        }

        [Test]
        public void TestReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.CreateFranc(2), "USD");
            AreEqual(Money.CreateDollar(1), result);
        }

        [Test]
        public void TestIdentityRate()
        {
            AreEqual(1, new Bank().Rate("USD", "USD"));
        }

        [Test]
        public void TestMixedAddition()
        {
            IExpression fiveBucks = Money.CreateDollar(5);
            IExpression tenFranc = Money.CreateFranc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveBucks.Plus(tenFranc), "USD");
            AreEqual(Money.CreateDollar(10), result);
        }

        [Test]
        public void TestSumPlusMoney()
        {
            IExpression fiveBucks = Money.CreateDollar(5);
            IExpression tenFrancs = Money.CreateFranc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            IExpression sum = new Sum(fiveBucks, tenFrancs).Plus(fiveBucks);
            Money result = bank.Reduce(sum, "USD");
            AreEqual(Money.CreateDollar(15), result);
        }

        [Test]
        public void TestSumTimes()
        {
            IExpression fiveBucks = Money.CreateDollar(5);
            IExpression tenFrancs = Money.CreateFranc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            IExpression sum = new Sum(fiveBucks, tenFrancs).Times(2);
            Money result = bank.Reduce(sum, "USD");
            AreEqual(Money.CreateDollar(20), result);
        }
    }
}