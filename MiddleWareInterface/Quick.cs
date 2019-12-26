using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms;

namespace MiddleWareInterface
{
    class Quick
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
