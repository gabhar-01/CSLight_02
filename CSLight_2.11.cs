using System;

namespace CSLight_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string bracketedText;
            bool isBracketedTextCorrect = true;

            int maxAmountOfNestedBrackets = 0;
            int currentAmountOfNestedBrackets = 0;
            int minBorder = 0;

            Console.Write("Введите скобочное выражение: ");
            bracketedText = Console.ReadLine();

            foreach (char bracket in bracketedText)
            {
                if (bracket == '(')
                {
                    currentAmountOfNestedBrackets++;

                    if (maxAmountOfNestedBrackets < currentAmountOfNestedBrackets)
                    {
                        maxAmountOfNestedBrackets = currentAmountOfNestedBrackets;
                    }
                }
                else if (bracket == ')')
                {
                    currentAmountOfNestedBrackets--;

                    if (currentAmountOfNestedBrackets < minBorder)
                    {
                        isBracketedTextCorrect = false;
                        break;
                    }
                }
                else
                {
                    continue;
                }
            }

            if (currentAmountOfNestedBrackets != minBorder || maxAmountOfNestedBrackets == minBorder)
            {
                isBracketedTextCorrect = false;
            }

            if (isBracketedTextCorrect == true)
            {
                Console.WriteLine("Строка является корректным скобочным выражением. Максимальная глубина вложенности скобок равна " +
                    maxAmountOfNestedBrackets + ".");
            }
            else
            {
                Console.WriteLine("Строка не является корректным скобочным выражением.");
            }

            Console.ReadKey();
        }
    }
}
