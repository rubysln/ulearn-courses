using System;

namespace BenfordsLaw
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(GetBenfordStatistics(""));
            PrintNumbers(GetBenfordStatistics(null));
            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("7"));
            PrintNumbers(GetBenfordStatistics("9"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));

            var tallestBuildings = "Kockums Crane 138\nMurudeshwara Temple 76\nMjøstårnet 85\nÉole 96\nSchapfen Mill Tower 115";
            PrintNumbers(GetBenfordStatistics(tallestBuildings));
        }

        static void PrintNumbers(int[] inputArray)
        {
            foreach(var result in inputArray)
            {
                Console.Write(inputArray[result] + ", ");
            }
            Console.WriteLine();
        }

        static int[] GetBenfordStatistics(string text)
        {
            var statistics = new int[10];
            if (text != null)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    try
                    {
                        if (!char.IsDigit(text, i - 1))
                            if (char.IsDigit(text, i)) statistics[int.Parse(text.Substring(i, 1))]++;
                    }
                    catch
                    {
                        if (char.IsDigit(text, i)) statistics[int.Parse(text.Substring(i, 1))]++;
                    }
                }
            }
            return statistics;
        }
    }
}
