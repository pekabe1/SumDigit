using NUnit.Framework;
using SumDigit;

namespace Tests
{
    public class DigitsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("12314",11)]
        [TestCase("12345678901234567890xdsdsd", 90)]
        [TestCase("12",3)]
        [Test]
        public void SumDigits(string text, int expected)
        {
            Digits digits = new Digits(text);
            var result = digits.SumDigits();
            Assert.AreEqual(expected, result);
        }

      
    }
}