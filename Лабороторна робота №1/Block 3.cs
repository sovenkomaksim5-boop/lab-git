using System;
namespace Block3
{
    internal class program
    {
        static void Main(string[] args)
        {
            double  x = double.Parse(Console.ReadLine());
            double  y = double.Parse(Console.ReadLine());
            if (y >= -1 && y <= 1 && (4 * x * x + 9 * y * y <= 36))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
