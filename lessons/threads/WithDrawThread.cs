namespace lessons.threads;

public class WithDrawThread
{
    public static void WithDraw()
    {
        try
        {
            BankAcnt bnk = new BankAcnt(10);
            Thread[] threads = new Thread[15];
            
            Thread.CurrentThread.Name = "Main Thread";

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(bnk.issueWithdraw);
                t.Name = i.ToString();
                threads[i] = t;
            }
            
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);
                
                threads[i].Start();
                
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);
            }
            
            Console.WriteLine("Current Priority : {0}",
                Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending",
                Thread.CurrentThread.Name);
            
            // for (int i = 0; i < 15; i++)
            // {
            //     Console.WriteLine("Thread {0} Alive : {1} and Ending ",
            //         threads[i].Name, threads[i].IsAlive);
            //     threads[i].Join();
            //     Console.WriteLine("Thread {0} Alive : {1} and Ending ",
            //         threads[i].Name, threads[i].IsAlive);
            // }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}