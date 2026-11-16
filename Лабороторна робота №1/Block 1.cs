using System;

class Block1
{
    static void Main()
    {
        Console.Write("Введіть радіус основи циліндра: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть висоту циліндра: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double V = Math.PI * r * r * h;

        Console.WriteLine($"Об'єм циліндра = {V:F2}");
    }
}