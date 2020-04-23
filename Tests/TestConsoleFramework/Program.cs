using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestConsoleFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"D:\1.txt";

            var x = File.ReadAllLines(path);
            StringBuilder sb = new StringBuilder();
            for (int a = 0; a < x.Length; a++)
            {
                //Console.WriteLine($"{a}%3={a % 3}");
                
                if (a%3 == 2)
                {
                    //Console.WriteLine(x[a]);
                    sb.AppendLine(x[a]);
                }
                
               
            }

            File.WriteAllText(@"D:\суб.txt", sb.ToString());

            //Console.ReadLine();
        }
    }
}
