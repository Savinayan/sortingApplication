using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
   public class Selection
    {
        public int[] sort(int[] arr) {
            int[] outarr = arr;
            //
            int tmp, min;
            for (int j = 0; j < outarr.Length - 1; j++)
            {
                min = j;
                for (int k = j + 1; k < outarr.Length; k++)
                {
                    if (outarr[k] < outarr[min])
                    {
                        min = k;
                    }
                }
                tmp = outarr[min];
                outarr[min] = outarr[j];
                outarr[j] = tmp;
            }
            //for (int i = 0; i < outarr.Length-1; i++)
            //{
            //    Console.WriteLine(outarr[i]);
            //}
           // outarr = arr;
            return outarr;
        }
    }
}
