using System;
using System.Text;

namespace Lesson005_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть кількість клієнтів: \n N = ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1, i = 0;

            do
            {
                i++;
                factorial *= i;
            } while (i < n);

            Console.WriteLine($"N! = {factorial}");
        }
    }
}
