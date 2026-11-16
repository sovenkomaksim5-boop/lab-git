using System;

class Block2
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());

        double numerator = Math.Pow(x * x + 4 * x + 5, 1.0 / 7);

        double denominator = (Math.Abs(9 * Math.Pow(x, 6) - 1) + 2) / (8 * x * x + 21 * x - 3)
                             - Math.Abs(x - 1);

        double result = numerator / denominator;

        Console.WriteLine(result);
    }
}