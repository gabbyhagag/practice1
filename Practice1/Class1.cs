using System;
using System.Collections.Generic;
using System.Linq;



class class1
{
    public class Accumul
    {

    //string bubu = "gaBbYsddsfrFCFDHBbkjbdBNJKDKJkjnbdkjnJDBBbYsddsfrFC" +
    //"jnJDBNKJNBdjnkjdkkjnJDBNKJNBdjnkjdkjnJKNKdjknFDGGFDfdeDFfdDDd";
    //string roro = Accumul.Accum(bubu);
    //Console.WriteLine(roro);
    //Console.ReadLine();

        public static String Accum(string s)
        {
            //return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
            string sUP = s.ToUpper();
            string sLOW = s.ToLower();
            double temp = 1 + s.Length;
            temp = temp / 2;
            temp = temp * s.Length;
            temp = temp + s.Length - 1;
            int size = (int)temp;
            char[] cNew = new char[size];
            int cunter = 0;

            //for 5 times
            for (int i = 0; i < s.Length; i++)
            {
                cNew[cunter] = sUP[i];
                cunter++;
                while (cunter <= lastOne(s, i) + i - 1)
                {
                    cNew[cunter] = sLOW[i];
                    cunter++;
                }
                if (i != s.Length - 1)
                    cNew[cunter] = '-';
                cunter++;
            }
            return new string(cNew);
        }
        public static int lastOne(string s, int index)
        {
            if (index == 0)
            {
                index--;
            }
            index++;
            double lastOne = 1 + index;
            lastOne = lastOne / 2;
            lastOne = lastOne * index;
            return (int)lastOne;
        }
    }
}