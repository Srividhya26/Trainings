using ArithmeticOperation;
using System.Collections.Generic;
using Xunit;


namespace ArithmeticOperationTesting
{
    public class UnitTest1
    {
        [Fact]
        public void AddNumbers()
        {
            var num1 = 10;
            var num2 = 30;
            var expectedResult = 40;

            var sum = Program.Add(num1, num2);

            Assert.Equal(sum,expectedResult);
        }

        [Fact]
        public void SubNumbers()
        {
            var value1 = 20;
            var value2 = 18;
            var expectedResult = 2;

            var sub = Program.Sub(value1, value2);

            Assert.Equal(sub, expectedResult);
        }

        [Fact]
        public void MulNumbers()
        {
            var number1 = 30;
            var number2 = 25;
            var expectedValue = 750;

            var mul = Program.Mul(number1, number2);

            Assert.Equal(mul, expectedValue);
        }

        [Fact]
        public void DivNumbers()
        {
            var number1 = 50;
            var number2 = 10;
            var expectedValue = 5;

            var div = Program.Div(number1, number2);

            Assert.Equal(div, expectedValue);
        }
    }

    
}
