using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class XOFunc
    {
        public static bool XO(string input)
        {
            int cO = 0;
            int cX = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('o') || input[i].Equals('O'))
                {
                    cO++;
                    continue;
                }
                if (input[i].Equals('x') || input[i].Equals('X'))
                {
                    cX++;
                    continue;
                }
            }
            if (cO == cX) return true;
            return false;
        }
    }
}
