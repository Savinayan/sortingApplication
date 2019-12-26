using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleWareInterface
{
    class CSVtoArr
    {
        public int[] toArray(string input)
        {
            char[] sep = new char[1];
            sep[0] = ',';
            string[] output = input.Split(sep);
            int[] arr=new int[output.Length];
            int count = 0;
            foreach (var ch in output) 
            {
                arr[count] = Convert.ToInt32(ch);
                count++;
            }
            return arr;
        }

        public string toDisplay(int[] arr)
        {
            string str = "<table style='border:1px solid #000'>";
            str = str + "<tr>";
            foreach(var ch in arr)
            {
                str = str + "<td>" + ch.ToString() + "</td>";
            }
            str = str + "</tr>";
            str = str+"</table>";
            return null;
        }
    }
}
