using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortingWebApplication.Models
{
    public class Model
    {
        public string input { get;set; }
        public string output { get; set; }

        public Model() {
            input = "0";
            output = "0";
        }
    }
}