namespace lessons.genericsCode;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;

public class Program
{
    public static void learn()
    {
        // List<T>
        List<int> list = new List<int> { 1, 2, 3 };

        // Dictionary<TKey, TValue>
        Dictionary<string, int> dict = new Dictionary<string, int> { { "Alice", 30 }, { "Bob", 25 } };

        // HashSet<T>
        HashSet<string> set = new HashSet<string> { "Apple", "Banana" };

        // Queue<T>
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");

        // Stack<T>
        Stack<string> stack = new Stack<string>();
        stack.Push("Top");

        // SortedList<TKey, TValue>
        SortedList<string, int> sortedList = new SortedList<string, int> { { "Alice", 30 }, { "Bob", 25 } };

        // SortedSet<T>
        SortedSet<int> sortedSet = new SortedSet<int> { 3, 1, 2 };

        // LinkedList<T>
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("Node");

        // ObservableCollection<T>
        ObservableCollection<string> observableCollection = new ObservableCollection<string> { "Item" };
        observableCollection.CollectionChanged += (sender, e) => Console.WriteLine($"Action: {e.Action}");

        // ConcurrentDictionary<TKey, TValue>
        ConcurrentDictionary<string, int> concurrentDict = new ConcurrentDictionary<string, int>();
        concurrentDict.TryAdd("Concurrent", 1);
    }
}