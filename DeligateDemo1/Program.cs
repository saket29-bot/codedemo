using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateDemo1
{
    //delegate Declaration..........
    delegate void MyDelegate(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            //direct invokation
            //Program.Greeting("Hello");
            //Indirect invoking using Delegates
            //step2:Instatianate and initialize
            Program p=new Program();
            MyDelegate del = null;
            //del = Greeting;//It overeride the Hello method and Greeting gets implemenrted.
            del += Greeting;//Subscribing or adding new method address,both method implemented
            del += Hello;
            //del -= p.Hello;//Unsubscribe or removing the method
            //Step 3:Deligate Calling
            del("Happy birthday");
        }
        public static void Greeting(string msg)
        {
            Console.WriteLine("Greeting:"+msg);
        }
        public static void Hello(string msg)
        {
            Console.WriteLine("Helo:"+msg);
        }
    }
}
