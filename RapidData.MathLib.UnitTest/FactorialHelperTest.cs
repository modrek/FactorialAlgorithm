using System;
using System.Numerics;
using Xunit;

namespace RapidData.MathLib.UnitTest
{
    public class FactorialHelperTest
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 120)]
        [InlineData(15, 1307674368000)]
        public void Factorial1A_ValidArgumentTest(int input, BigInteger expectedResult)
        {
            var actualResult = FactorialHelper.Factorial1A(input);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 120)]
        public void Factorial1B_ValidArgumentTest(int input, BigInteger expectedResult)
        {
            var actualResult = FactorialHelper.Factorial1B(input);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(7, 105)]
        [InlineData(8, 105)]
        [InlineData(9, 945)]
        public void UnevenFactorial_ValidArgumentTest(int input, BigInteger expectedResult)
        {
            var uIntInput = uint.Parse(input.ToString());
            var actualResult = FactorialHelper.UnevenFactorial(uIntInput);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(3, 36)]
        [InlineData(5, 14400)]
        public void SquareFactorial_ValidArgumentTest(int input, BigInteger expectedResult)
        {
            var actualResult = FactorialHelper.SquareFactorial(input);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Factorial1A_InValidArgumentTest()
        {
            Assert.Throws<ArgumentException>(
                 () =>
                 {
                     FactorialHelper.Factorial1A(-1);
                 });
        }

        [Fact]
        public void Factorial1B_InValidArgumentTest()
        {
            Assert.Throws<ArgumentException>(
                 () =>
                 {
                     FactorialHelper.Factorial1B(-1);
                 });
        }

        [Fact]
        public void SquareFactorial_InValidArgumentTest()
        {
            Assert.Throws<ArgumentException>(
                 () =>
                 {
                     FactorialHelper.SquareFactorial(-1);
                 });
        }
    }
}