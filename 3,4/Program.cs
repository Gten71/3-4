using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|     x       |      y       |");
            for (double x = 0.1; x <= 2.5; x += 0.2)
            {
                double y = Math.Sqrt(x) - 2 * Math.Cos(0.5 * Math.PI * x);
                Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
            }
        }
    }
}
