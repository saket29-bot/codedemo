using Demo1.BusinessLayer;
using Demo1.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fno, sno;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 1st no");
                    fno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter sno");
                    sno = int.Parse(Console.ReadLine());
                    Calculator c = new Calculator();
                    Console.WriteLine($"sum of {fno} and {sno} is {c.Sum(fno,sno)}");
                }
                catch(ZeroInputException z)
                {
                    Console.WriteLine(z.Message);
                }
                catch(FormatException f)
                {
                    Console.WriteLine("Enter only numbers");

                }
                catch(OverflowException o)
                {
                    Console.WriteLine("Enter small int no only");
                }
            }
        }
    }
}
