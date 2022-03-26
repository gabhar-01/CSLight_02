using System;

namespace CSLight_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiple1 = 3;
            int multiple2 = 5;
            int maxNumber = 101;
            int sum = 0;

            Random random = new Random();
            int number = random.Next(multiple1, maxNumber);

            for (int i = multiple1; i <= number; i++)
            {
                if (i % multiple1 == 0 || i % multiple2 == 0) 
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Сумма всех положительных чисел, меньших случайного числа {number}," +
                $"которые кратны {multiple1} или {multiple2}, равна {sum}.");
        }
    }
}
