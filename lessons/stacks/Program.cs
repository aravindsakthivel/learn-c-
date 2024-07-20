using System.Collections;

namespace lessons.stacks;

public class Program
{
    public static void learn()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        
        Console.WriteLine("Peek: {0}", stack.Peek());
        
    }
}