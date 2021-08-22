using System;
using TestingInClasses;
using Xunit;
using Moq;

namespace ClassesTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockInfo = new Mock<ISalary>();

            var value = new Employee();
            double expectedValue = 24000;

            value.SalaryPerMonth = 20000;
            double actualValue = value.increasedPay(20);

            Assert.Equal(expectedValue, actualValue);

        }
    }
}
