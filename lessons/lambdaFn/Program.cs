namespace lessons.lambdaFn;

public class Program
{
    
    public static void learn()
    {

        LambdaFn();
        
        WhereMethod();
        
        SelectMethod();
        
        ZipMethod();
        
        AggregateMethod();
    }
    
    private delegate double Arithmetic(double a, double b);

    private static void LambdaFn()
    {
        Func<int, int, int> fn = (x, y) => x * y;

        Arithmetic add = (x, y) => x + y;
        
        Console.WriteLine(add(2, 3));
        
        Console.WriteLine(fn(5, 6));
        
    }
    

    private static void WhereMethod()
    {
        List<int> numList = new List<int> { 1, 2, 3, 4, 5 };

        List<int> evenList = numList.Where(a => a % 2 == 0).ToList();
        
        var oddList = numList.Where(a => a % 2 != 0);
        
        foreach (var num in oddList)
        {
            Console.WriteLine(num);
        }


        Console.WriteLine("Even numbers");
        foreach (var num in evenList)
        {
            Console.WriteLine(num);
        }
    }

    private static void SelectMethod()
    {
        Console.WriteLine("Squares of numbers from 1 to 10:");
        var oneTo10 = new List<int>();
        oneTo10.AddRange(Enumerable.Range(1, 10));
        var squares = oneTo10.Select(x => x * 2);
        foreach (var num in squares)
        {
            Console.WriteLine(num);
        }
    }

    private static void ZipMethod()
    {
        Console.WriteLine("Sum of elements from two lists:");
        var listOne = new List<int>(new int[] { 1, 2, 3, 4, 5 });
        var listTwo = new List<int> { 6, 7, 8, 9, 10 };
        
        var sumList = listOne.Zip(listTwo, (a, b) => a + b).ToList();
        
        foreach (var num in sumList)
        {
            Console.WriteLine(num);
        }
    }
    

    private static void AggregateMethod()
    {
        var numList1 = new List<int> { 1, 2, 3, 4, 5 };
        var sum = numList1.Aggregate((a, b) => a + b);
        
        Console.WriteLine("Sum of elements in the list: " + sum);
    }
    
    
}