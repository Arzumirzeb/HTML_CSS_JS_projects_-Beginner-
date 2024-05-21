using System;

class Program
{
    static void Main(string[] args)
    {
        ulong product = CalculateProductOfPrimes(255);
        Console.WriteLine("Product of the first 255 prime numbers: " + product);
    }

    static ulong CalculateProductOfPrimes(int n)
    {
        ulong product = 1;
        int count = 0;
        ulong number = 2;

        while (count < n)
        {
            if (IsPrime(number))
            {
                product *= number;
                count++;
            }
            number++;
        }

        return product;
    }

    static bool IsPrime(ulong number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        ulong sqrt = (ulong)Math.Sqrt(number);
        for (ulong i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
