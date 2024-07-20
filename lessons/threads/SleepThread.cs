namespace lessons.threads;

public class SleepThread
{
    public static void Sleep()
    {
        Console.WriteLine("Sleep Thread started {0} ", "\n");
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine("Sleep Thread 1 ");
            Thread.Sleep(1000);
        }
    }
}