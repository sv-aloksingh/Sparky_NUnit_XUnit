using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Sparky
{
    public class CalculatorXUnitTests
    {
        [Fact]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.AddNumbers(10, 20);

            //Assert via Classic Model
            Assert.Equal(30, result);
            //Assert via Constraint Model
            //Assert.That(30, Is.EqualTo(result));
        }

        [Theory]
        [InlineData(11)]
        [InlineData(13)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int a)
        {
            //Arrange 
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.IsOddNumber(a);

            //Assert via Classic Model
            Assert.True(result);
            //Assert via Constraint Model
            Assert.Equal(result, true);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(18)]
        public void IsOddNumber_InputEvenNumber_ReturnFalse(int a)
        {
            //Arange
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.IsOddNumber(a);

            //Assert via Classic Model
            Assert.False(result);
            //Assert via Constraint Model
            Assert.Equal(result, false);
        }

        //Combine Unit test with ExpectedResult
        [Theory]
        [InlineData(11, true)]  //For Odd
        [InlineData(10, false)] //For Even
        public void IsOddNumber_InputNumber_ReturnTrueWithOdd(int a, bool expectedResult)
        {
            //Arrange 
            Calculator calc = new Calculator();
            //Act 
            var result = calc.IsOddNumber(a);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5.4, 10.5, 15.9)] //15.9
        [InlineData(5.43, 10.53, 15.959999999999999)] //15.93
        [InlineData(5.49, 10.59, 16.08)] //16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b, double exp)
        {
            //Arrange 
            Calculator calculator = new Calculator();
            //Act 
            var result = calculator.AddNumbersDouble(a,b);
            //Assert
            Assert.Equal(exp, result); //where 1 is delta between range value
        }

        [Fact]
        public void OddRange_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            List<int> expectedOddRange = new List<int>() { 5, 7, 9}; //Min = 5, Max = 10

            //Act
            List<int> result = calculator.GetOddNumberRange(5, 10);

            //Assert
            Assert.Equal(expectedOddRange, result);
            Assert.Contains(7, result);
            Assert.NotEmpty(result);
            Assert.Equal(3, result.Count);
            Assert.DoesNotContain(6, result);
            Assert.Equal(result.OrderBy(x=>x), result);
            //Assert.Equal(result, Is.Unique);
        }
    }
}
