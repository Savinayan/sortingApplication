using System;
using System.Collections.Generic;
using System.Text;
using SortingAlgorithms;

namespace MIddleWare
{
    public class Insertion
    {
        public string process(string input)
        {
            CSVtoArr cSVtoArr = new CSVtoArr();
            SortingAlgorithms.Insertion bl = new SortingAlgorithms.Insertion();
            int[] arr = cSVtoArr.toArray(input);
            arr = bl.sort(arr);
            return cSVtoArr.toDisplay(arr);
        }
    }
}
