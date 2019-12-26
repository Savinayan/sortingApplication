using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms;

namespace MiddleWareInterface
{
    class Bubble
    {
        public string process(string input)
        {
            CSVtoArr cSVtoArr = new CSVtoArr();
            SortingAlgorithms.Bubble bl = new SortingAlgorithms.Bubble();
            int[] arr = cSVtoArr.toArray(input);
            arr = bl.sort(arr);
            return cSVtoArr.toDisplay(arr);
        }
    }
}
