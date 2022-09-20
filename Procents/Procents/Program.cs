using System;

namespace Procents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите следующие данные через пробел: исходную сумму, процентную ставку и срок вклада в месяцах");
            string initialData = Console.ReadLine();
            double result = Calculate(initialData);
            Console.WriteLine(result);  
        }

        static double Calculate(string initialData)
        {
            string[] splitInitialData = initialData.Split(' ');
            double amount = double.Parse(splitInitialData[0]);
            double interestRate = double.Parse(splitInitialData[1]);
            double termOfDepositInMonths = double.Parse(splitInitialData[2]);
            double procentInMonth = (interestRate / 12) / 100;
            double procentAmountinMonth =  procentInMonth * amount;
            return Math.Round(procentAmountinMonth * termOfDepositInMonths + amount);
        }
    }
}
