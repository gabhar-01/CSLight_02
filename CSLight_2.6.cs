using System;

namespace CSLight_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeroCursorPositionX = 10;
            int zeroCursorPositionY = 0;

            char dog = '@';
            bool isDogHere = false;
            int dogY = 15;
            int dogX = 15;

            string dogName = "";
            bool doesDogHasAName = false;
            int dogNameY = 14;
            int dogNameX = 14;

            int barkY = 16;
            int barkX = 15;

            bool isRunning = true;
            int userInput;

            while (isRunning) 
            {
                Console.WriteLine("Добро пожаловать на задний двор." +
                "\n Вы можете: " +
                "\n1 - Изменить время суток." +
                "\n2 - Завести собаку." +
                "\n3 - Дать питомцу имя." +
                "\n4 - Использовать команду \"Голос!\"" +
                "\n5 - Выйти из программы.\n");

                if (isDogHere == true) 
                {
                    Console.SetCursorPosition(dogY, dogX);
                    Console.WriteLine(dog);
                }

                if (doesDogHasAName == true)
                {
                    Console.SetCursorPosition(dogNameY, dogNameX);
                    Console.WriteLine(dogName);
                }

                Console.SetCursorPosition(zeroCursorPositionY, zeroCursorPositionX);
                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        if (Console.BackgroundColor == ConsoleColor.Black)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                        break;
                    case 2:
                        if (isDogHere == true)
                        {
                            Console.WriteLine("Зачем тебе ещё одна собака.");
                            Console.ReadKey();
                        }
                        else
                        {
                            isDogHere = true;
                        }
                        break;
                    case 3:
                        if (isDogHere == false)
                        {
                            Console.WriteLine("Здесь некому давать имён :(");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            if (doesDogHasAName == true)
                            {
                                Console.WriteLine(dogName + " не Альбус Персиваль Вульфрик Брайан Дамблдор, и, пожалуй, оставим это так.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Введите имя: ");
                                dogName = Console.ReadLine();
                                doesDogHasAName = true;
                            }
                            break;
                        }
                    case 4:
                        if (isDogHere == false)
                        {
                            Console.WriteLine("Здесь некому лаять...");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(barkY, barkX);
                            Console.WriteLine(" -Гав.");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Неопознанная команда.");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
