using System;

namespace CSLight_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 27;
            int N;

            Console.WriteLine($"Дано N ({minNumber} <= N <= {maxNumber})");

            Random random = new Random();
            N = random.Next(minNumber, maxNumber+1);
            Console.WriteLine("N = " + N);

            int minThreeDigitNaturalNumber = 100;
            int maxThreeDigitNaturalNumber = 999;

            int numberCounter = 0;
            
            for (int i = 0; i <= maxThreeDigitNaturalNumber; i += N)
            {
                if (i >= minThreeDigitNaturalNumber)
                {
                    numberCounter++;
                }
            }
           
            Console.WriteLine("Количество трехзначных натуральных чисел, которые кратны N, равно " + numberCounter + ".");
            Console.ReadKey();
        }
    }
}
