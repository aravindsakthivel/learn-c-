namespace lessons.operatorOverloading;

public class Program
{
    public static void learn()
    {
        Console.WriteLine("Operator Overloading ");
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        
        Point p3 = p1 + p2;
        
        Console.WriteLine(p3);
    }
}