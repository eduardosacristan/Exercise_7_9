//This program counts the number of digits of a given number.

using System;

class digits
{
    static void Main()
    {
        int one_digit = 0, two_digits = 0, three_digits = 0, more_digits = 0;
        
        Console.Write("Insert a number: ");
        string input = Console.ReadLine();
        
        while(input != "end")
        {
            int number = Convert.ToInt32(input);
            if(number != 0)
            {
                if(number/10 == 0) one_digit++; 
                else if (number/100 == 0) two_digits++;  
                else if (number/1000 == 0) three_digits++;  
                else more_digits++;  
            }
        input = Console.ReadLine();
        }

    Console.WriteLine("one: {0} two: {1} three: {2} more: {3}",
    one_digit, two_digits, three_digits, more_digits);
    }
}

