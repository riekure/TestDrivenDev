using System;
using NUnit.Framework;

namespace TestDrivenDevTest
{
    [TestFixture]
    public class FibonacciTest
    {
        int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n-1) + Fib(n-2);
        }

        [Test]
        public void TestFibonacci()
        {
            int[,] cases = new int[,] { { 0, 0 }, { 1, 1 }, { 2, 1 }, {3, 2} };
            for (int i = 0; i < cases.GetLength(0); i++)
            {
                Assert.AreEqual(cases[i, 1], Fib(cases[i, 0]));
            }
        }
    }
}