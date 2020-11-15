using System;

namespace Lesson005_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Sum:");
            while (true)
            {
                Console.WriteLine("Enter 2 numbers (a<b) :");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int suma = 0;

                if (a < b)
                {
                    while (a < b - 1)
                    {
                        a++;
                        suma += a;
                    }
                    Console.WriteLine($"Sum(a;b) = {suma}");
                    break;
                }
                else
                    Console.WriteLine("Error!  a >= b");
            }

            Console.WriteLine("Odd numbers:");
            while (true)
            {
                Console.WriteLine("Enter 2 numbers (a<b) :");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if (a < b)
                {
                    Console.WriteLine($"Odd numbers between a & b :");

                    while (a < b - 1)
                    {
                        a++;
                        if (a % 2 == 1)
                            Console.WriteLine($"     {a}");
                    }
                    break;
                }

                else
                    Console.WriteLine("Error!  a >= b");
            }
        }
    }
}
