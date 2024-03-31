using System;

class WhileDescription
{
    static void Main()    
    {
        int count = 0;
        while (count < 3)
        {
            Console.WriteLine("Hello");
            count++;
            
        }

        int index = 5;
        while (index > 0) 
        {
            Console.WriteLine($"Hello. {index}");
            index--;
        }
    }
}