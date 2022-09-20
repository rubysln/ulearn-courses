using System;

namespace EvenSet
{
    class Program
    {
        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }
        static void Main()
        {
            Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));
        }

        static string GetSuit(Suits suit)
        {
            var suitsCount = Enum.GetNames(typeof(Suits)).Length;
            for(int i = 0; i < suitsCount; i++)
            {
                if (suit == 0)
                    return "ama gomosek";
            }
            return "yare gomosek";
        }
    }
}
