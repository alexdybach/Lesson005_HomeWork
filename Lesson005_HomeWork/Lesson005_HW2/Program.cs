using System;

namespace Lesson005_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rectangle1 = 4, rectangle2 = 9;
            int r_triangle = 6;
            int eql_triangle = 7, halfside = (int)(eql_triangle / 2);

            Console.WriteLine("Rectangle");
            for (int i = 0; i < rectangle1; i++)
            {
                for (int j = 0; j < rectangle2; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Right triangle");
            for (int i = 0; i < r_triangle; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Equilateral triangle");
            for (int i = 0; i < eql_triangle; i++)
            {
                if (halfside >= 0)
                {
                    for (int k = 0; k < halfside; k++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 0; j < 2 * i + 1; j++)
                    {

                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                halfside--;
            }
        }
    }
}
