using System;
using Xunit;
using Fahrenheit;

namespace TestProject1
{
    public class UnitTest1
    {
        //Test case for positive value alone (Fahrenheit to celsius)
        [Fact]
        public void Test1()
        {
            
            var fahrenheit = 97;
            var result = 36.111111111111114;

            var convert = Methods.Convert(fahrenheit);

            Assert.Equal(convert, result);
        }

        //Test case for both positive and negative values (Fahrenheit to celsius)

        [Theory]
        [InlineData(-89, -67.22222222222223)]
        [InlineData(97, 36.111111111111114)]
        [InlineData(0, -17.77777777777778)]
        public void MultipleTestCase(int fahrenheit,double expectedValue)
        {
            double actualValue = Methods.Convert(fahrenheit);

            Assert.Equal(expectedValue, actualValue);
        }

        //For Area of the triangle using single values

        [Fact]
        public void Test2()
        {
            var breadth = 10;
            var height = 20;

            var expectedResult = 100;

            var actualValue = Methods.AreaOfTriangle(breadth, height);

            Assert.Equal(expectedResult, actualValue);
        }

        //Test cases for area of triangle using various values

        [Theory]
        [InlineData(10,20,100)]
        [InlineData(10,-20,-100)]
        [InlineData(-10,-20,100)]
        [InlineData(-10,20,-100)]
        public void Testcase4(int b,int h,int expectedValue)
        {
            double actualValue = Methods.AreaOfTriangle(b, h);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
