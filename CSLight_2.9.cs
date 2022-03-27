using System;

namespace CSLight_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 27;

            Console.WriteLine($"Дано N ({minNumber} <= N <= {maxNumber})");

            int minThreeDigitNaturalNumber = 100;
            int maxThreeDigitNaturalNumber = 999;

            int numberCounter = 0;
            
            for (int i = minNumber; i <= maxNumber; i++)
            {
                for (int j = minThreeDigitNaturalNumber; j <= maxThreeDigitNaturalNumber; j += i)
                {
                    numberCounter++;
                }
            }

            Console.WriteLine("Количество трехзначных натуральных чисел, которые кратны N, равно " + numberCounter + ".");
            Console.ReadKey();
        }
    }
}
