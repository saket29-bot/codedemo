using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace myfirstapp
{
    internal class ExceptionTest
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            try
            {
                arr[11] = 1;
            }
            catch (IndexOutOfRangeException e)
            {
                string mess = e.Message;
                string h = e.StackTrace;
                Console.WriteLine(mess);
                Console.WriteLine(h);
                Console.WriteLine(e.ToString());
            }
        }
    }
}

