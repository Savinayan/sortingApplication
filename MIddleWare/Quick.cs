using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms;

namespace MIddleWare
{
    public class Quick
    {
        public string process(string input)
        {
            CSVtoArr cSVtoArr = new CSVtoArr();
            SortingAlgorithms.Quick bl = new SortingAlgorithms.Quick();
            int[] arr = cSVtoArr.toArray(input);
            arr = bl.sort(arr);
            return cSVtoArr.toDisplay(arr);
        }
    }
}
