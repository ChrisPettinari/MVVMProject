using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMProject.Model
{
    class Data
    {
        public class Result
        {
            public string title { get; set; }
            public string href { get; set; }
            public string ingredients { get; set; }
            public string thumbnail { get; set; }
        }

        public class Recipe
        {
            public string title { get; set; }
            public double version { get; set; }
            public string href { get; set; }
            public IList<Result> results { get; set; }





            //foob
        }
    }
}
