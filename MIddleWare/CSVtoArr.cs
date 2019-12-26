using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIddleWare
{
    public class CSVtoArr
    {
        public int[] toArray(string input)
        {
            char[] sep = new char[1];
            sep[0] = ',';
            string[] output = input.Split(sep);
            int[] arr = new int[output.Length];
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
            string str2 = " ";
            str = str + "<tr>";
            foreach (var ch in arr)
            {
                str = str + "<td>" + ch.ToString() + "</td>";
                str2 = str2 + ch.ToString() + " ";
            }
            str = str + "</tr>";
            str = str + "</table>";
            return str2; ;
        }
    }
}
