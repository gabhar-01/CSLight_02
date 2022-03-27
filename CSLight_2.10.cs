using System;

namespace CSLight_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToTheDegree = 2;
            int maxNumber = 100;
            int degree = 0;
            int raisedNumber = 0;

            Random random = new Random();
            int number = random.Next(numberToTheDegree, maxNumber);
            Console.WriteLine("Заданное число: " + number);

            for (int i = numberToTheDegree; i <= number; i *= numberToTheDegree)
            {
                degree++;
                raisedNumber = i;
            }

            degree++;
            raisedNumber *= numberToTheDegree;
            Console.WriteLine($"Минимальная степень {numberToTheDegree}, превосходящая заданное число: {degree}");
            Console.WriteLine($"Число {numberToTheDegree} в найденной степени: {raisedNumber}");
            Console.WriteLine($"{number} < {raisedNumber}");
            Console.ReadKey();
        }
    }
}
