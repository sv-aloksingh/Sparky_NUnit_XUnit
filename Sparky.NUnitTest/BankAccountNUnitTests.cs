using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount account;
        [SetUp]
        public void Setup()
        {
            
        }

        //Integration test is something where we test, all funtionalities.
        //Unit test is something we test only for class functionalities, not integration with classes.
        //Like if we test Bank Account Class and Log funtionality both than we will do integration test.
        //We don't want any dependency of LogBook in BankAccount, so we will create Fake Logger.

        [Test]
        public void BankDepositLogFakker_Add100_ReturnTrue()
        {
            //Arrange already done in setup.
            BankAccount bankAccount = new BankAccount(new LogFakker());
            //Act
            var result = bankAccount.Deposit(100);

            //Assert
            Assert.IsTrue(result);
            Assert.AreEqual(100, bankAccount.GetBalance());
            Assert.That(bankAccount.GetBalance(), Is.EqualTo(100));
        }

        [Test]
        public void BankDeposit_Add100_ReturnTrue()
        {
            //Mock LogFakker with Moq framework.
            var logMock = new Mock<ILogBook>();
            logMock.Setup(x => x.Message("")); //we can setup anthing Deposit Invoked...

            //Arrange already done in setup.
            BankAccount bankAccount = new BankAccount(logMock.Object);
            //Act
            var result = bankAccount.Deposit(100);

            //Assert
            Assert.IsTrue(result);
            Assert.AreEqual(100, bankAccount.GetBalance());
            Assert.That(bankAccount.GetBalance(), Is.EqualTo(100));
        }
    }
}
