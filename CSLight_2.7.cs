using System;

namespace CSLight_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSymbol;

            Console.Write("Введите имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите символ: ");
            userSymbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            int symbolsCount = userName.Length + 2;

            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(userSymbol);
            }

            Console.WriteLine();
            Console.WriteLine(userSymbol + userName + userSymbol);

            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(userSymbol);
            }

            Console.ReadKey();
        }
    }
}
