using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    public interface ILogBook
    {
        void Message(string message);
    }

    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class LogFakker : ILogBook
    {
        public void Message(string message)
        {
            //Nothing, to behave like LogBook 
            //With Empty entity so that we can test only BankAccount functionalities.

            //But in real world we will not be creating LogFakker instead we will create Mocking.
            //To avoid dummy and useless codes.
            //It will take lot of resources and time. because in real world we have multiple depdencies.

            //We have different types of mocking frameworks.
            //MOQ, NMock3, FakeItEasy, NSubstitute 
        }
    }
}