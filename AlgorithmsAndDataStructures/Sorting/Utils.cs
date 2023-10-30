using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Sorting
{
    internal class Utils
    {
        public static int[] FillArray(int num)
        {
            int[] res = new int[num];

            for (int i = 0; i < num; i++)
            {
                res[i] = num - i;
            }

            return res;
        }
    }
}
