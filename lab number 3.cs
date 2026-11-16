using System;

class Program
{
    
    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;      
        }

        int i = 2;
        while (i * i <= n)    
        {
            if (n % i == 0)
            {
                return false; 
            }
            i++;
        }
        return true;          
    }

    static void PrintAllQPow2p1PrimeNumbers(int n)
    {
        int q = 1;
        int x = q * q + 1;     

        while (x <= n)
        {
            if (IsPrime(x))
            {
                Console.Write(x + " ");
            }
            q++;
            x = q * q + 1;     
        }
        Console.WriteLine();
    }

    static void PrintAllFibonacciPrimeNumbers(int n)
    {
        int a = 1;            
        int b = 1;             

        while (b <= n)
        {
            if (IsPrime(b))
            {
                Console.Write(b + " ");
            }
            int next = a + b;  
            a = b;
            b = next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Введіть n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Прості числа виду q^2 + 1:");
        PrintAllQPow2p1PrimeNumbers(n);

        Console.WriteLine("Прості числа Фібоначчі:");
        PrintAllFibonacciPrimeNumbers(n);
    }
}