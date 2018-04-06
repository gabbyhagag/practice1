using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack1 s = new Stack1();

            s.Push(1);
            s.Push(-2);
            s.Push(-5);

            int res = s.Max();

            Console.WriteLine(res);
            Console.ReadLine();

            //Stopwatch s = Stopwatch.StartNew();
            //Console.WriteLine(Solution(8500));
            //s.Stop();
            //Console.WriteLine(s.Elapsed.TotalMilliseconds);
            //Console.ReadLine();
        }


    }
}
