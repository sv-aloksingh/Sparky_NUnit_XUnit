//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Sparky
//{
//    [TestFixture]
//    class CustomerXUnitTests
//    {
//        //Global initialization for class
//        //Initialize Customer object as soon as enter in current file, so that ready to use.(This is arrange phase)
//        private Customer customer;
//        [SetUp]
//        public void Setup()
//        {
//            customer = new Customer();
//        }

//        [Test]
//        public void GreetAndCombineNames_InputFirstAndLastName_ReturnFullName()
//        {
//            //Arrange
//            //var customer = new Customer();

//            //Act 
//            var result = customer.GreetAndCombineNames("Alok", "Singh");
//            //Assert
//            Assert.Multiple(() =>
//            {
//                Assert.AreEqual("Hello, Alok Singh", result);
//                Assert.That(result, Is.EqualTo("Hello, Alok Singh"));
//                Assert.That(result, Does.Contain(",").IgnoreCase);  //Just to show Assert.That has more inbuilt functions.
//                Assert.That(result, Does.StartWith("Hello"));  ////Just to show Assert.That has more inbuilt functions.
//                Assert.That(result, Does.EndWith("Singh"));
//                Assert.That(result, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-z]{1}[a-z]+")); //regular expression test case.
//            });
//        }


//        [Test]
//        public void GreetMessage_NotGreeted_ReturnNull()
//        {
//            //Arrange 
//            //Customer customer = new Customer();

//            //Act
//            var result = customer.GreetMessage;
//            //Assert
//            Assert.IsNull(result);
//        }

//        [Test]
//        public void DiscountCheck_DefaultCustomer_ReturnCorrectDiscountRange()
//        {
//            var result = customer.Discount;
//            Assert.That(result, Is.InRange(10, 25));
//        }

//        [Test]
//        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
//        {
//            customer.GreetAndCombineNames("Alok", "");

//            Assert.IsNotNull(customer.GreetMessage);
//            Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
//        }

//        [Test]
//        public void GreetMessage_EmptyFirstName_ThrowsExcception()
//        {
//            var exceptionDetails = Assert.Throws<ArgumentException>(
//                () => customer.GreetAndCombineNames("","Singh"));

//            Assert.AreEqual("Empty First Name", exceptionDetails.Message);
//            Assert.That(()=> customer.GreetAndCombineNames("","Singh"), 
//                Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));
//        }
//    }
//}
