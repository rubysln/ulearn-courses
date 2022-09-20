using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var birthsCounts = new double[31];
            foreach(var man in names)
            {
                if (man.Name == name && man.BirthDate.Day != 1)
                    birthsCounts[man.BirthDate.Day - 1]++;
            }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                new string[] {"1","2","3","4","5","6","7","8","9","10","11",
                    "12","13","14","15","16","17","18","19","20","21",
                    "22","23","24","25","26","27","28","29","30","31" },
                birthsCounts) ;
        }
    }
}