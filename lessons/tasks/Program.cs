namespace lessons.tasks;

public class Program
{
    public static async Task learn()
    {
        var id_1 = Thread.CurrentThread.ManagedThreadId;
        Console.WriteLine("Thread ID -1: {0}", id_1);
        Console.WriteLine("{0}", "\n");
        Console.WriteLine("Starting Tasks Tea ");
        await TeaMaker.Prepare();

        Console.WriteLine("Starting Tasks NR ");
        // var id0 = Thread.CurrentThread.ManagedThreadId;
        // Console.WriteLine("Thread ID 0: {0}", id0);
        // await NetworkReq.MakeCall();
        // var id5 = Thread.CurrentThread.ManagedThreadId;
        // Console.WriteLine("Thread ID 5: {0}", id5);
    }
}