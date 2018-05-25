using System;
using System.Collections.Generic;

namespace mvcdemo.Models
{
    public class MyPair {
        public string Code1 {get; set;}
        public string Code2 {get; set;}
    }

    public class PairUploadViewModel {
        public List<MyPair> FirstList {get; set; }
        
        public List<MyPair> SecondList {get; set; }
    }
}