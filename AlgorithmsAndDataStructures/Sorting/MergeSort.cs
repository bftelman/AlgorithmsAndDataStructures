using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Sorting
{
    internal class MergeSort
    {
        private static void Merge(int[] arr, int beg, int pivot, int end)
        {
            int lenOfLeft = pivot - beg + 1;
            int lenOfRight = end - pivot;

            int[] leftSubArray = new int[lenOfLeft];
            int[] rightsSubArray = new int[lenOfRight];
            int i;
            int j;

            for (i = 0; i < lenOfLeft; i++)
            {
                leftSubArray[i] = arr[beg + i];
            }

            for (j = 0; j < lenOfRight; j++)
            {
                rightsSubArray[j] = arr[pivot + j + 1];
            }

            i = 0; j = 0;

            int k = beg;


            while (i < lenOfLeft && j < lenOfRight)
            {
                if (leftSubArray[i] <= rightsSubArray[j])
                {
                    arr[k] = leftSubArray[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = rightsSubArray[j];
                    j = j + 1;
                }

                k = k + 1;
            }

            while (i < lenOfLeft)
            {
                arr[k] = leftSubArray[i];
                i = i + 1;
                k = k + 1;
            }

            while (j < lenOfRight)
            {
                arr[k] = rightsSubArray[j];
                j = j + 1;
                k = k + 1;
            }
        }

        public static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }
    }
}
