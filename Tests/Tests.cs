using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        // Group 2 Unit Tests
        MiscLib.GroupTwoFunctions ml1 = new MiscLib.GroupTwoFunctions();

        // CalcRectPerimiter Test
        [Theory]
        [InlineData(20, 5, 5)]
        public void CalcRectPerim_Test(int expected, int length, int width)
        {
            Assert.Equal(expeccted, ml1.CalcRectPerimeter(length, width));
        }

        // IsTriangularNum Test
        [Theory]
        [InlineData(true, 3)]
        public void IsTriangularNum_Test(bool expected, int num)
        {
            Assert.Equal(expected, ml1.IsTriangularNum(num));
        }

        // FarenheitToCelcius Test
        [Theory]
        [InlineData(29, 85)]
        public void FarenheitToCelcius(int expected, int farenheit)
        {
            Assert.Equal(expected, ml1.FarenheitToCelcius(farenheit));
        }

        // CheckWhiteSpace Test
        [Theory]
        [InlineData(true, "Does this sentence have any spaces?")]
        [InlineData(false, "ThisStringHasNoSpaces")]
        public void CheckWhiteSpace_Test(bool expected, string word)
        {
            Assert.Equal(expected, ml1.CheckWhiteSpace(word));
        }

        // CamelString Test
        [Theory]
        [InlineData("TeStInG", "testing")]
        [InlineData("UnItTeStInG", "unittesting")]
        public void CamelString_Test(string expected, string word)
        {
            Assert.Equal(expected, ml1.CamelString(word));
        }

        // CountDigits Test
        [Theory]
        [InlineData(8, "54783211")]
        [InlineData(4, "9507")]
        [InlineData(10, "5743668321")]
        public void CountDigits_Test(int expected, string word)
        {
            Assert.Equal(expected, ml1.CountDigits(word));
        }
    }
}
