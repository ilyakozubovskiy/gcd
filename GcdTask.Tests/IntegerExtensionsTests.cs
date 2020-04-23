using System;
using NUnit.Framework;
using static GcdTask.IntegerExtensions;

namespace GcdTask.Tests
{
    [TestFixture]
    public class IntegerExtensionsTest
    {
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(8, 9, ExpectedResult = 1)]
        [TestCase(50, 250, ExpectedResult = 50)]
        [TestCase(12, 60, ExpectedResult = 12)]
        [TestCase(2672, 5678, ExpectedResult = 334)]
        [TestCase(10927782, 6902514, ExpectedResult = 846)]
        [TestCase(1590771464, 1590771620, ExpectedResult = 4)]
        public int FinGcd_With_All_Positive_Numbers(int a, int b) => FindGcd(a, b);

        [TestCase(30, -12, ExpectedResult = 6)]
        [TestCase(10927782, -6902514, ExpectedResult = 846)]
        [TestCase(-1590771464, 1590771620, ExpectedResult = 4)]
        [TestCase(1590771464, -1590771620, ExpectedResult = 4)]
        [TestCase(-10234567, -234568989, ExpectedResult = 97)]
        [TestCase(-10234562, -7872334, ExpectedResult = 2)]
        public int FinGcd_With_Some_Negative_Numbers(int a, int b) => FindGcd(a, b);

        [TestCase(945, 0, ExpectedResult = 945)]
        [TestCase(0, -301, ExpectedResult = 301)]
        [TestCase(10927782, 0, ExpectedResult = 10927782)]
        [TestCase(-1590771464, 0, ExpectedResult = 1590771464)]
        public int FinGcd_With_One_Zero_Number(int a, int b) => FindGcd(a, b);

        [TestCase(int.MaxValue, int.MinValue, ExpectedResult = 1)]
        public int FinGcd_With_Max_And_Min_Integer_Numbers(int a, int b) => FindGcd(a, b);

        [Test]
        public void FinGcd_With_Two_Zero_Numbers_Throw_ArgumentException() =>
            Assert.Throws<ArgumentException>(() => FindGcd(0, 0),
                "Two numbers cannot be 0 at the same time.");
    }
}