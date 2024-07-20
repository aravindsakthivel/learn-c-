namespace lessons.tasks;

public class NetworkReq
{
    public static async Task MakeCall()
    {
        try
        {
            var id1 = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Thread ID 1: {0}", id1);
            var client = new HttpClient();
            var id2 = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Thread ID 2: {0}", id2);
            var response = client.GetAsync("https://google.com");
            var id3 = Thread.CurrentThread.ManagedThreadId;
            var a = 0;
            for (var i = 0; i < 1_000_000_00; i++)
            {
                a += i;
            }
            Console.WriteLine("Thread ID 3: {0}", id3);
            var content = await response.Result.Content.ReadAsStringAsync();
            // Console.WriteLine(content);
            var id4 = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Thread ID 4: {0}", id4);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}