using System;

namespace CSLight_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userPhrase;
            int iterationCount;

            Console.WriteLine("Введите фразу, которую хотите зациклить: ");
            userPhrase = Console.ReadLine();
            Console.Write("Введите желаемое количество повторов: ");
            iterationCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < iterationCount; i++)
            {
                Console.WriteLine(userPhrase);
            }
        }
    }
}
