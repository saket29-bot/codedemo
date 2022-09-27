using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FileIODemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.Write();
            StreamReader sr = new StreamReader("C:\\Users\\ADMIN\\Documents\\Sample.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();

        }
        private static void ReadAll()
        {
            StreamReader sr = new StreamReader("C:\\Users\\ADMIN\\Documents\\Sample.txt");
            try
            {
                string allData = sr.ReadToEnd();
                Console.WriteLine(allData);
            }
            finally//mandatory to close any connection using finally
            {
                sr.Close();
            }
        }
        private static void Write()
        {
            string data = "Next Some data";
            StreamWriter sw = new StreamWriter("C:\\Users\\ADMIN\\Documents\\Sample.txt", true);//giving 2nd parameter we use it in append mode
            sw.WriteLine(data);
            sw.Close();//always close the Steam Line(which is nothing but buffer)
        }
    }
}
