using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.WriteLine("bir eded daxil edin: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    continue;

                while (number > 0)
                {
                    number /= 10;
                    count++;
                }

                Console.WriteLine(count);

                break;
            }
        }
    }
}
