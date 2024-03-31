using System;

class WhileEven
{
    static void Main()
    {
        int sum = 0;

        int i = 1;
        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
            i++;
        }
        Console.WriteLine($"1~100 even:  {sum}");
    }
}