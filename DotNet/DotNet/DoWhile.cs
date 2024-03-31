using System;

class DoWhileDemo
{
    static void Main(string[] args)
    {
        int sum = 0;

        int i = 1;
        do
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                sum += i;
            }
            i++;
        } while (i <= 100);

        Console.WriteLine(sum);
    }
}