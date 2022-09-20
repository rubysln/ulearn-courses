using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new string[30];
            int dayInt = 2;
            for (int i = 0; i < days.Length; i++)
            {
                string day = Convert.ToString(dayInt);
                days[i] = "" + day;
                dayInt++;

            }
            var months = new string[12];
            int monthInt = 1;
            for(int i = 0; i < months.Length; i++)
            {
                string month = monthInt.ToString();
                months[i] = "" + month;
                monthInt++;
            }
            var result = new double[31, 12];
            foreach (var name in names)
                if (name.BirthDate.Day != 1)
                    result[name.BirthDate.Day - 2, name.BirthDate.Month - 1]++;
            return new HeatmapData(
                "Пример карты интенсивностей",
                result, 
                days, 
                months);
        }
    }
}