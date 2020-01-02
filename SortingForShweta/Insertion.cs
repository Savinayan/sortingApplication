using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Insertion
    {
        public int[] sort(int[] arr)
        {
            int[] outarr = new int[arr.Length];
            // put your code here
            int n = arr.Length, val, flag;
            for (int i = 0; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            outarr = arr;// delete this line when you code
            return outarr;
        }
    }
}
