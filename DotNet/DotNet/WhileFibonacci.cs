using System;

class WhileFibonacci
{
    static void Main(string[] args)
    {
        int first = 0;
        int second = 1;

        while (second <= 20)
        {
            Console.WriteLine(second);
            int temp = first + second;
            first = second;
            second = temp;
        }
    }
}