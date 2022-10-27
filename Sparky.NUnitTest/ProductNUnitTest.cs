using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class ProductNUnitTest
    {
        //It is not good appraoch, that we are creating interface just for mocking, like customer class.
        [Test]
        public void GetProductPrice_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            //Arrange
            Product product = new Product() { Price = 50 };
            //Act
            var result = product.GetPrice(new Customer() { IsPlatinum = true });
            //Assert
            Assert.That(result , Is.EqualTo(40));
        }
        //Moq Customer class by creating interface.
        [Test]
        public void GetProductPriceMoqAbuse_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(x => x.IsPlatinum).Returns(true);


            //Arrange
            Product product = new Product() { Price = 50 };
            //Act
            var result = product.GetPrice(customer.Object);
            //Assert
            Assert.That(result, Is.EqualTo(40));
        }
    }
}
