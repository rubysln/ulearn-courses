using System;

namespace WriteBoard
{
    class Program
    {
        static void Main()
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }

        static void WriteBoard(int size)
        {
            var a = "";
            for (int i = 0; i < size; i++)
            {
                a += "#";
                i++;
                while (i < size)
                {
                    a += ".";
                    break;
                }
            }
            var a1 = "";
            for (int i = 0; i < size; i++)
            {
                a1 += ".";
                i++;
                while (i < size)
                {
                    a1 += "#";
                    break;
                }
            }
            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{a}");
                    i++;
                    break;
                }
                while (i<size)
                {
                    Console.WriteLine($"{a1}");
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
