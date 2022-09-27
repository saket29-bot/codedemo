using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st no");
            int fno=int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd no");
            int sno=int.Parse(Console.ReadLine());
            int sum = fno + sno;
            Console.WriteLine($"The sum of no is {sum}");
        }
    }
}
