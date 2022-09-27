using Demo1.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.BusinessLayer
{
    /// <summary>
    /// Calculator is used for simple mathematical ccalculation
    /// </summary>
    internal class Calculator
    {/// <summary>
    /// Find sum of two non zero positive even number
    /// </summary>
    /// <param name="a">1st no</param>
    /// <param name="b">2nd no</param>
    /// <returns>Sum of numbers</returns>
    /// <exception cref="ZeroInputException"></exception>
    /// <exception cref="NegativeInputException"></exception>
        public int Sum(int a,int b)
        {
            if (a == 0 || b == 0)
                throw new ZeroInputException("Enter only non zero value");
            if (a < 0 || b < 0)
                throw new NegativeInputException();
            if (a % 2 != 0 || b % 2 != 0)
                throw new OddInputException();
            return a + b;
        }
    }
}
