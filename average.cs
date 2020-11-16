// This program calculates the average of all the numbers entered 

using System;
public class Average
{
    public static void Main()
    {
        double total = 0, number_b, denominator = 0, average;
        string input;
        
        Console.Write("Insert a mark: ");
        input = Console.ReadLine(); 
        
        while(input != "end")
        {  
            number_b = Convert.ToDouble(input);
            denominator++;   
            total += number_b;  
            Console.Write("Insert a mark: ");
            input = Console.ReadLine();
        }
        
        if(denominator != 0)
        {
            average = total/denominator; 
            Console.WriteLine("The average is {0}.",average);
        }
    }
}
