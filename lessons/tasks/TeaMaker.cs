namespace lessons.tasks;

public class TeaMaker
{

    public static async Task Prepare()
    {
        await MakeTea();
    }
    private static async Task<string> BoilWater()
    {

        Console.WriteLine("Start the kettle ");

        Console.WriteLine("Waiting for the kettle to boil ");

        await Task.Delay(500);

        var currentTimeStamp = DateTime.Now;

        Console.WriteLine("Kettle boiled at {0} ", currentTimeStamp);

        return "water";
    }

    private static async Task MakeTea()
    {
        var boilingWater = BoilWater();

        Console.WriteLine("Take the cup ");

        // Offload the CPU-bound loop operation to a background thread
        var loopResult = await Task.Run(() =>
        {
            var id0 = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Thread ID 0: {0}", id0);
            var a = 0;
            for (var i = 0; i < 1_000_000_00; i++)
            {
                a += i;
            }
            return a; // Assuming you want to use the result for something
        });

        var currentTimeStamp = DateTime.Now;

        Console.WriteLine("Cups taken at {0} ", currentTimeStamp);

        var water = await boilingWater;

        Console.WriteLine("Pour {0} into the cup ", water);

    }
}