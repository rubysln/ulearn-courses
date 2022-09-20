using System;

namespace GetPoweredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            PrintArray(GetPoweredArray(arrayToPower, 1));

            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));

            // не забывайте про частные случаи:
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
        }

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] array = new int[arr.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(arr[i], power);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write($"{item} ");
            Console.WriteLine("\n");
        }
    }
}
