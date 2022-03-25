using System;

namespace CSLight_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            string keyword;

            while (isWorking) 
            {
                keyword = Console.ReadLine();
                
                if (keyword == "exit")
                {
                    isWorking = false;
                }
            }
        }
    }
}
