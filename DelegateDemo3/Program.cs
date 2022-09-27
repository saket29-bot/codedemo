using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Application of delegate to pass method as parameter in onother method
            //client1-Show process List
            //client 2-Show Processes starting with s
            /*FilterDelegte f = new FilterDelegte(FilterByName);
            ProcessManager.ShowProcessList(f);*/
            //client 3-filter by size
            ProcessManager.ShowProcessList(FilterbySize);//We can directly use without creating object

            //Anonimous delegate
            ProcessManager.ShowProcessList(delegate (Process p)//same opeartion as Filter by size
                {
                    return p.WorkingSet64 >= 32 * 1024 * 1024;
                });

            //Lambda(statement based lambda)
            ProcessManager.ShowProcessList((Process p)=>//same opeartion as Filter by size
            {
                return p.WorkingSet64 >= 32 * 1024 * 1024;
            });
            //LAmbda (expression based lambda)-Light weight syntax for anonymous delegates
            ProcessManager.ShowProcessList(p => p.WorkingSet64 >= 32 * 1024 * 1024);

            List<int> numbers = new List<int>() { 123, 23, 45, 66, 67 };
            Func<int, bool> nfilter = new Func<int, bool>(IsEven);
            var sum = numbers.Sum();
            var evenSum1 = numbers.Where(nfilter).Sum();//using delegate
            var evenSum=numbers.Where(x => x %2== 0).Sum();//using lambda expression



        }
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        static bool FilterByName(Process p)
        {
            if (p.ProcessName.StartsWith("S"))
            {
                return true;
            }
            else
                return false;
        }
        static bool FilterbySize(Process p)
        {
            return p.WorkingSet64 >= 32 * 1024 * 1024;
        }
    }
    //Declare delegate
    public delegate bool FilterDelegte(Process p);
    class ProcessManager
    {
        public static void ShowProcessList(FilterDelegte filter)
        {
            foreach(var p in Process.GetProcesses())
            {
                if(filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
}
