using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIddleWare
{
    public class Bubble
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
