using System;

namespace DeleteSpace
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine(RemoveStartSpaces("               "));
			Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
		}
		static string RemoveStartSpaces(string text)
		{
			string firstCharText = text.Substring(0, 1);
			while (text.Length >= 1 && (firstCharText == " " || firstCharText == "	" || firstCharText == "\n" || firstCharText == "\r"))
			{
					text = text.Remove(0,1);
				try { firstCharText = text.Substring(0, 1); }
                catch { return null; }
			}
			return text;
		}
    }
}
