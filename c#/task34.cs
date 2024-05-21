using System;

class Program
{
    static void Main()
    {
        int n = 4;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }
    }
}
