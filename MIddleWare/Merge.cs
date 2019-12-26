using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms;

namespace MIddleWare
{
    public class Merge
    {
        public string process(string input)
        {
            CSVtoArr cSVtoArr = new CSVtoArr();
            SortingAlgorithms.Merge bl = new SortingAlgorithms.Merge();
            int[] arr = cSVtoArr.toArray(input);
            arr = bl.sort(arr);
            return cSVtoArr.toDisplay(arr);
        }
    }
}
