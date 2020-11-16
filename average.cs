// This program calculates the average of all the numbers entered 

using System;
public class Average
{
    public static void Main()
    {
        double total = 0, number, denominator = 0, average;
        string input;
        
        Console.Write("Insert a mark: ");
        input = Console.ReadLine(); 
        
        while(input != "end")
        {  
            number = Convert.ToDouble(input);
            denominator++;   
            total += number;  
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
