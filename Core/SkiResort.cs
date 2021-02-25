using System;
using System.Collections.Generic;

namespace Assessment.Core
{
    public class SkiResort
    {
        public string Place { get; set; }
        public int NumOfLifts { get; set; }

        public SkiResort(string place, int numOfLifts)
        {
            Place = place;
            NumOfLifts = numOfLifts;
        }

    }
}
