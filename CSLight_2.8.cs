using System;

namespace CSLight_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Cat";
            string userInput;
            int numberOfTries = 3;

            while (numberOfTries !=0 )
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    numberOfTries = 0;
                    Console.WriteLine("Ночью все кошки серы.");
                    Console.ReadKey();
                }
                else
                {
                    numberOfTries--;
                    Console.WriteLine("Пароль неверный. У вас осталось " + numberOfTries + " попытки.");
                }
            }
        }
    }
}
