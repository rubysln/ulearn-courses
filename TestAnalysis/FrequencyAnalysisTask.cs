using System.Collections.Generic;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var result = new Dictionary<string, string>();
            foreach(var e in text)
            {
                var nGramm = GetFrequencyDictionary(e);
            }
            return result;
        }

        public static string GetFrequencyDictionary(List<string> text)
        {
            var result = "";
            foreach(var e in text)
            {

            }
            return result;
        }
   }
}