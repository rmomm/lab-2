using System;

namespace lab2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fact_WithZero_ReturnsOne()
        {
            int input = 0;
            int result = Factorial.Fact(input);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Fact_WithPositiveNumber_ReturnsCorrectFactorial()
        {
            int input = 5;
            int exp = 120;
            int result = Factorial.Fact(input);
            Assert.That(result, Is.EqualTo(exp));
        }

        [Test]
        public void Fact_WithNegativeNumber_ThrowsArgumentException()
        {
            int input = -1;
            Assert.Throws<ArgumentException>(() => Factorial.Fact(input));
        }
    }
}