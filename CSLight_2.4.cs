using System;

namespace CSLight_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiple3 = 3;
            int multiple5 = 5;
            int sum = 0;

            Random rand = new Random();
            int number = rand.Next(0, 101);


            for (int i = multiple3; i <= number; i++)
            {
                if (i % multiple3 == 0 || i % multiple5 == 0) 
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сумма всех положительных чисел, меньших случайного числа " + number + ", которые кратны 3 или 5, равна " + sum + ".");
        }
    }
}
