using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Multiplesof3or5
    {
        public static int Solution(int value)
        {
            //return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
            //return ComponentSum(value, 3) + ComponentSum(value, 5) - ComponentSum(value, 15); //best
            value--;
            HashSet<int> nums = new HashSet<int>();
            int count3 = value / 3;
            int count5 = value / 5;
            int temp3 = count3 * 3 + 3;
            int temp5 = count5 * 5 + 5;

            for (int i = 0; i <= count3; i++)
            {
                nums.Add(temp3 -= 3);
            }
            for (int i = 0; i <= count5; i++)
            {
                nums.Add(temp5 -= 5);
            }

            return nums.Sum();
        }
        public static int ComponentSum(int value, int component)
        {
            int times = (value - 1) / component;
            return times * (times + 1) / 2 * component;
        }
    }
}
