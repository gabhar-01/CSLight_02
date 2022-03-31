using System;

namespace CSLight_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            float userRub = random.Next(50, 500);
            float userUsd = random.Next(50, 500);
            float userEur = random.Next(50, 500);

            float rubToUsd = 0.0089f;
            float rubToEur = 0.0083f;

            float usdToRub = 91;
            float usdToEur = 0.8772f;

            float eurToRub = 100;
            float eurToUsd = 1.06f;

            int enoughMoney = 0;
            int exchangeAmount;
            int userInput;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Конвертор валют." +
                "\nВаш баланс:" +
                "\nРубли: " + userRub +
                "\nДоллары: " + userUsd +
                "\nЕвро: " + userEur);

                Console.WriteLine("\n1 - Обменять рубли на доллары." +
                    "\n2 - Обменять рубли на евро." +
                    "\n3 - Обменять доллары на рубли." +
                    "\n4 - Обменять доллары на евро." +
                    "\n5 - Обменять евро на рубли." +
                    "\n6 - Обменять евро на доллары." +
                    "\n7 - Выйти из программы.\n");

                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Обмен рублей на доллары.");
                        Console.Write("Какую сумму рублей вы хотите обменять: ");
                        exchangeAmount = Convert.ToInt32(Console.ReadLine());
                        
                        if (userRub - exchangeAmount < enoughMoney)
                        {
                            Console.WriteLine("Недостаточно средств для совершения данной операции.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            userRub -= exchangeAmount;
                            userUsd += exchangeAmount * rubToUsd;
                            break;
                        }

                    case 2:
                        Console.WriteLine("Обмен рублей на евро.");
                        Console.Write("Какую сумму рублей вы хотите обменять: ");
                        exchangeAmount = Convert.ToInt32(Console.ReadLine());
                        
                        if (userRub - exchangeAmount < enoughMoney)
                        {
                            Console.WriteLine("Недостаточно средств для совершения данной операции.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            userRub -= exchangeAmount;
                            userEur += exchangeAmount * rubToEur;
                            break;
                        }

                    case 3:
                        Console.WriteLine("Обмен долларов на рубли.");
                        Console.Write("Какую сумму долларов вы хотите обменять: ");
                        exchangeAmount = Convert.ToInt32(Console.ReadLine());
                        
                        if (userUsd - exchangeAmount < enoughMoney)
                        {
                            Console.WriteLine("Недостаточно средств для совершения данной операции.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            userUsd -= exchangeAmount;
                            userRub += exchangeAmount * usdToRub;
                            break;
                        }

                    case 4:
                        Console.WriteLine("Обмен долларов на евро.");
                        Console.Write("Какую сумму долларов вы хотите обменять: ");
                        exchangeAmount = Convert.ToInt32(Console.ReadLine());
                        
                        if (userUsd - exchangeAmount < enoughMoney)
                        {
                            Console.WriteLine("Недостаточно средств для совершения данной операции.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            userUsd -= exchangeAmount;
                            userEur += exchangeAmount * usdToEur;
                            break;
                        }

                    case 5:
                        Console.WriteLine("Обмен евро на рубли.");
                        Console.Write("Какую сумму евро вы хотите обменять: ");
                        exchangeAmount = Convert.ToInt32(Console.ReadLine());
                        
                        if (userEur - exchangeAmount < enoughMoney)
                        {
                            Console.WriteLine("Недостаточно средств для совершения данной операции.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            userEur -= exchangeAmount;
                            userRub += exchangeAmount * eurToRub;
                            break;
                        }

                    case 6:
                        Console.WriteLine("Обмен евро на доллары.");
                        Console.Write("Какую сумму евро вы хотите обменять: ");
                        exchangeAmount = Convert.ToInt32(Console.ReadLine());
                        
                        if (userEur - exchangeAmount < enoughMoney)
                        {
                            Console.WriteLine("Недостаточно средств для совершения данной операции.");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            userEur -= exchangeAmount;
                            userUsd += exchangeAmount * eurToUsd;
                            break;
                        }

                    case 7:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка. Неопознанная команда.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            }
        }
    }
}
