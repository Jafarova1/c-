using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16, count = 0;
            if (n > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }

                }
                if (count > 2)
                {
                    Console.WriteLine("murekkebdir");

                }
                else
                {
                    Console.WriteLine("sadedir");

                }
            }
            else
            {
                Console.WriteLine("basqa reqem daxil et");
            }

        }
    }
}
