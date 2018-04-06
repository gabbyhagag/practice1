using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class FindNextSquare
    {
        public static long FindNextSquareFunc(long num)
        {
            double t = Math.Sqrt(num);
            if (t % 1 != 0) return -1;
            t++;
            num = Convert.ToInt64(t);

            return num * num;

        }
    }
}
