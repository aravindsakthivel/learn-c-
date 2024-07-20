namespace lessons.threads;

public class BaseThrd
{
    private static void Print()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Base Thread 1 ");
        }
    }
    public static void BaseETrhd()
    {
        Thread tr = new Thread(Print);
        tr.Start();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Main Thread 0 ");
        }
    }
}