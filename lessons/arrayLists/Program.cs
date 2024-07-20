using System.Collections;

namespace lessons.arrayLists;

public class Program
{
    public static void learn()
    {
        Console.WriteLine("Learn about array lists ");
        ArrayList list = new ArrayList();
        
        list.Add(1);
        list.Add(1);
        list.Add("Hello");
        
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("Array list {0} ", list);
        //Print all elements in the array list
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        
        list.Remove(1);
        
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("Array list {0} ", list);
        
        //Print all elements in the array list
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}