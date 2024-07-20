using System.Collections;

namespace lessons.queue;

public class Program
{
    public static void learn()
    {
        Queue queue = new Queue();
        
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        
        Console.WriteLine("Queue: {0}", queue);
        
        Console.WriteLine("1 in Queue {0}", queue.Contains(1));
        Console.WriteLine("Remove 1: {0}", queue.Dequeue());
        Console.WriteLine("Peek: {0}", queue.Peek());
        
    }
}