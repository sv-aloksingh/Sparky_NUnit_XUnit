using System;
using System.Collections.Generic;

namespace Sparky
{
    public class Calculator
    {
        public List<int> NumberRange; //To hold range of odd numbers
        public Calculator()
        {
            NumberRange = new List<int>();
        }

        //Test for int case
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        //Test for Double case
        public double AddNumbersDouble(double a, double b)
        {
            return a + b;
        }

        //Test for boolean case
        public bool IsOddNumber(int a)
        {
            return a % 2 != 0;
        }

        //From the given range, add all odd element to NumberRange collection.
        public List<int> GetOddNumberRange(int min, int max)
        {
            NumberRange.Clear();
            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                    NumberRange.Add(i);
            }
            return NumberRange;
        }
    }
}
