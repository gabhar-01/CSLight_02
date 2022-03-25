using System;

namespace CSLight_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = 96;
            int step = 7;
            
            for (int firstNumber = 5; firstNumber <= lastNumber; firstNumber += step) 
            {
                Console.Write(firstNumber + " ");
            }
        }
    }
}
