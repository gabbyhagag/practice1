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

            s.Push(10);
            s.Push(9);
            s.Push(11);
            s.Push(10);
            s.Push(15);
            s.Push(7);
            s.Push(7);
            s.Push(16);
            s.Push(4);
            s.Push(1);
            s.Push(33);
            s.Push(5);
            s.Pop();
            s.Pop();

            Console.WriteLine(s.Max());
            Console.ReadLine();

            //Stopwatch s = Stopwatch.StartNew();
            //Console.WriteLine(Solution(8500));
            //s.Stop();
            //Console.WriteLine(s.Elapsed.TotalMilliseconds);
            //Console.ReadLine();
        }


    }
}
