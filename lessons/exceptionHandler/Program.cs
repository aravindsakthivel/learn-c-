namespace lessons.exceptionHandler;
using System;

public class Program
{
    public static void learn()
    {
        double x = 1;
        double y = 0;
        
        try
        {
            double result = DoDivision(x, y);
            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("This is always run");
        }
    }

    static double DoDivision(double x, double y)
    {
        if (y == 0)
        {
            throw new Exception("Cannot divide by zero");
        }

        return x / y;
    }
}