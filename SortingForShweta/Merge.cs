using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Merge
    {
        public  int[] sort(int[] arr)
        {
            int[] outarr = new int[arr.Length];
            // put your code here
             public  void mergemethod(int[] numbers, int left, int mid, int right)
            {
               int[] temp = new int[25];
                int i, left_end, num_elements, tmp_pos;
                left_end = (mid - 1);
                tmp_pos = left;
                num_elements = (right - left + 1);
                while ((left <= left_end) && (mid <= right))
                {
                    if (numbers[left] <= numbers[mid])
                        temp[tmp_pos++] = numbers[left++];
                    else
                        temp[tmp_pos++] = numbers[mid++];
                }
                while (left <= left_end)
                    temp[tmp_pos++] = numbers[left++];
                while (mid <= right)
                    temp[tmp_pos++] = numbers[mid++];
                for (i = 0; i < num_elements; i++)
                {
                    numbers[right] = temp[right];
                    right--;
                }
            }
             public  static void sortmethod(int[] numbers, int left, int right)
            {
                int mid;
                if (right > left)
                {
                    mid = (right + left) / 2;
                    sortmethod(numbers, left, mid);
                    sortmethod(numbers, (mid + 1), right);
                    mergemethod(numbers, left, (mid + 1), right);
                }
            }
            public  void Main(string[] args)
            {
               // int[] numbers = { 13, 18, 71, 25, 12, 41, 9, 6, 4 };
                Console.WriteLine("MergeSort :");
                sortmethod(numbers, 0, numbers.Length - 1);
                for (int i = 0; i < numbers.Length; i++)
                    Console.WriteLine(numbers[i]);
            }

            outarr = arr;// delete this line when you code
            return outarr;
        }
    }
}
