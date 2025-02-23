// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.IO.Pipelines;

public class TryCatch
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first number: ");
        string fNum = Console.ReadLine();

        Console.WriteLine("Please enter your last number: ");
        string lNum = Console.ReadLine();

        try 
        {
            int num1 = Convert.ToInt32(fNum);

            int num2 = Convert.ToInt32(lNum);

            int quotient = Divide(num1,num2);
            Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Could not convert to int...");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            // This is useful because it attempts to provide the relative location of an error. This could significantly
            // increase efficieny especially when you are working on a code base that you are not familiar with
            Console.WriteLine($"Check for errors... \n{ex.StackTrace}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Divide by zero");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            Console.WriteLine($"Check for errors... \n{ex.StackTrace}");                    
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow error");
            Console.WriteLine($"Detailed error message: {ex.Message}");            
            Console.WriteLine($"Check for errors... \n{ex.StackTrace}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unknown Error");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            Console.WriteLine($"Check for errors... \n{ex.StackTrace}");
        }

        

    }

    static int Divide(int i, int j)
    {
        int result = i/j;
        return result;
    }
}
