using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;

namespace TestApp
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
    }
    class Program
    {
        public static void Main()
        {
            var rnd = new Random();
            //Console.WriteLine(rnd.NextDouble(rnd, 10, 20));
            Console.WriteLine(RandomExtensions.NextDouble(rnd, 10, 20));
        }
    }
}
