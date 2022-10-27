using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int result = calc.AddNumbers(10, 20);

            //Assert via Classic Model
            Assert.AreEqual(30, result);
            //Assert via Constraint Model
            Assert.That(30, Is.EqualTo(result));
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int a)
        {
            //Arrange 
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.IsOddNumber(a);

            //Assert via Classic Model
            Assert.IsTrue(result);
            //Assert via Constraint Model
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(12)]
        [TestCase(18)]
        public void IsOddNumber_InputEvenNumber_ReturnFalse(int a)
        {
            //Arange
            Calculator calculator = new Calculator();

            //Act
            var result = calculator.IsOddNumber(a);

            //Assert via Classic Model
            Assert.IsFalse(result);
            //Assert via Constraint Model
            Assert.That(result, Is.False);
        }

        //Combine Unit test with ExpectedResult
        [Test]
        [TestCase(11, ExpectedResult = true)]  //For Odd
        [TestCase(10, ExpectedResult = false)] //For Even
        public bool IsOddNumber_InputNumber_ReturnTrueWithOdd(int a)
        {
            //Arrange 
            Calculator calc = new Calculator();
            //Act 
            var result = calc.IsOddNumber(a);
            //Assert
            return result;
        }

        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] //15.93
        [TestCase(5.49, 10.59)] //16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange 
            Calculator calculator = new Calculator();
            //Act 
            var result = calculator.AddNumbersDouble(a,b);
            //Assert
            Assert.AreEqual(15.9, result, 1); //where 1 is delta between range value
        }

        [Test]
        public void OddRange_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            List<int> expectedOddRange = new List<int>() { 5, 7, 9}; //Min = 5, Max = 10

            //Act
            List<int> result = calculator.GetOddNumberRange(5, 10);

            //Assert
            Assert.AreEqual(expectedOddRange, result);
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
