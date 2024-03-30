using System;

class ForSum
{
    static void Main(string[] args)
    {
        int n = 3;
        int sum = 0;

        for (int i = 1; i <= n; i++) 
        {
            sum = sum + i;
        }

        Console.WriteLine($"{sum}");
    }
}