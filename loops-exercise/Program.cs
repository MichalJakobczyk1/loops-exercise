using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string aRaw = Console.ReadLine();
            string bRaw = Console.ReadLine();

            short a = short.Parse(aRaw);
            short b = short.Parse(bRaw);


            if (a - b == 0)
            {
                Console.WriteLine("empty");
            }

            else if (b - a == 0)
            {
                Console.WriteLine("empty");
            }

            if (a > b)
            {
                var numbersDifference = a - b;

                //Console.WriteLine(numbers);

                if (numbersDifference >= 10)
                {
                    for (int i = b + 1; i <= b + 3; i++)
                    {
                        Console.WriteLine($"{i}, ");
                    }

                    Console.WriteLine("..., ");

                    for (int i = a - 1; i <= a; i++)
                    {
                        Console.WriteLine($"{i}, ");
                    }
                }

                else
                {
                    for (int i = b + 1; i < a; i++)
                    {
                        Console.WriteLine($"{i}, ");
                    }

                }
            }

            else if (b > a)
            {
                //var numbers = a - b;

                // Console.WriteLine(numbers);

                //for (int i = a + 1; i < b; i++)
                // {
                //  Console.WriteLine($"{i}, ");
                //}

            }

        }
    }
}
