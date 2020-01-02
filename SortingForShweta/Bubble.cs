using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Bubble
    {
        public int[] sort(int[] arr)
        {
            int[] outarr = new int[arr.Length];
            // put your code here
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
               // outarr = arr;// delete this line when you code
            return arr;
        }
    }
}
