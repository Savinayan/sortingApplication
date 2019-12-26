using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms;

namespace MIddleWare
{
    public class Selection
    {
        public string process(string input)
        {
            CSVtoArr cSVtoArr = new CSVtoArr();
            SortingAlgorithms.Selection bl = new SortingAlgorithms.Selection();
            int[] arr = cSVtoArr.toArray(input);
            arr = bl.sort(arr);
            return cSVtoArr.toDisplay(arr);
        }
    }
}
