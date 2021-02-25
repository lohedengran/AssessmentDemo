using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Core
{
    public class Country
    {
        public string Name { get; set; }
        public List<SkiResort> SkiResorts { get; set; }

        public Country(string name)
        {
            Name = name;
            SkiResorts = new List<SkiResort>();
        }

        public void AddSkiResort(string place, int numOfLifts)
        {
            SkiResort s = new SkiResort(place, numOfLifts);
            SkiResorts.Add(s);

        }

        public int TotalNumberOfLifts()
        {
            int totalNumOfLifts = 0;
            foreach (var s in SkiResorts)
            {
                totalNumOfLifts = totalNumOfLifts + s.NumOfLifts;
            }

            return totalNumOfLifts;
        }

        public int TotalNumberOfLifts_Linq()
        {

            var q = SkiResorts
                .Select(s => s.NumOfLifts)
                .Sum();

            return q;
        }

        public string GetName()
        {
            return $"COUNTRY {Name.ToUpper()}";
        }

        public List<string> SkiResortNames()
        {
            List<string> skiResortNames = new List<string>();
            foreach (var s in SkiResorts)
            {
                skiResortNames.Add(s.Place);
            }
            return skiResortNames;
        }

        public List<string> SkiResortNames_Linq()
        {
            var q = SkiResorts
              .Select(s => s.Place)
              .ToList();              

            return q;
        }

        public int MaxLifts()
        {
            int max = 0;
            foreach (var l in SkiResorts)
            {
                if (l.NumOfLifts > max)
                    max = l.NumOfLifts;
            }
            return max;
        }

        public int MaxLifts_Linq()
        {
            var q = SkiResorts
                .Select(s => s.NumOfLifts)
                .OrderBy(s => s)
                .ToList();

            return q[q.Count - 1];
            
            

        }
    }
}
