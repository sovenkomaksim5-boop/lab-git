using System;

namespace DraftForLab2
{
    class Program
    {
        static void DoBlock_1()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int min = a;
            int max = a;

            for (int i = 2; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < min)
                    min = a;
                if (a > max)
                    max = a;
            }

            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
            Console.WriteLine("max - min = " + (max - min));
        }

        static void DoBlock_2()
        {
            int sum = 0;
            int number = 1;
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (number % 2 == 0)
                    sum = sum + x;
                number++;
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("sum = " + sum);
        }

        static void DoBlock_3()
        {
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum = sum + k % 10;
                k = k / 10;
            } while (k > 0);

            Console.WriteLine("sum = " + sum);
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1 - блок 1");
                Console.WriteLine("2 - блок 2");
                Console.WriteLine("3 - блок 3");
                Console.WriteLine("0 - вихід");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DoBlock_1();
                        break;
                    case 2:
                        DoBlock_2();
                        break;
                    case 3:
                        DoBlock_3();
                        break;
                    case 0:
                        Console.WriteLine("Кінець програми");
                        break;
                    default:
                        Console.WriteLine("Невірна команда");
                        break;
                }
            } while (choice != 0);
        }
    }
}