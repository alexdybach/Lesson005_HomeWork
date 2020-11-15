using System;

namespace Lesson005_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int w_rectangle = 8, h_rectangle = 5;

            for(int i=0;i<h_rectangle;i++)
            {
                for(int j=0;j<w_rectangle;j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}
