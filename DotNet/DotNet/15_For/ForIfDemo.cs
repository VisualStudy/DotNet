using System;

class ForIfDemo
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++) 
        {
            if (i % 3 == 0 && i % 4 == 0)
            { 
              sum += i; 
            }
        }

        Console.WriteLine(sum);
    }
}
