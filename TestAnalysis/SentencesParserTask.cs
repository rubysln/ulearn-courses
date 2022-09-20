using System.Collections.Generic;
using System.Text;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentenceList = new List<List<string>>();
            var separators = new[] { "!", ".", ";", ":", "?", "(", ")"}; // создаем массив разделителей
            var suggestions = text.Split(separators, System.StringSplitOptions.RemoveEmptyEntries); // разбираем исходный текст на предложения по разделителям
            foreach(var suggest in suggestions) // цикл проходит по предложениям
            {
                var wordList = new List<string>(); // создаем список слов для списка предложений
                var builder = new StringBuilder(); 
                foreach(var letter in suggest) // создаем цикл который пробегает по строке предложения
                {
                    if (char.IsLetter(letter) || letter == '\'') builder.Append(letter); // если элемент - слово или элемент ' то мы добавляем его в билдер
                    else builder.Append(" "); // иначе добавляем пробел (для дальнейшего сплита)
                }
                var stringSentence = builder.ToString().Split(' '); // сплитим билдер на массив строк
                foreach(var word in stringSentence) // циклом пробегаемся по массиву слов
                {
                    if (string.IsNullOrWhiteSpace(word)) ; // если строка - это null или пробел, мы её пропускаем, иначе добавляем в лист слов, изменяя регистр.
                    else wordList.Add(word.ToLower());
                }
                if(wordList.Capacity > 0) // если список слов не пустой, добавляем его в список предложений.
                sentenceList.Add(wordList);
            }
            return sentenceList;
        }
    }
}