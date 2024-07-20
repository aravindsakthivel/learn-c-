namespace lessons.stringBuilder;
using System;
using System.Text; // Required to use StringBuilder

public class Program
{

    public string name;

    public Program(string name = "Val")
    {
        this.name = name;
    }
    public static void learn()
    {
        // Create a new instance of StringBuilder
        StringBuilder sb = new StringBuilder();

        // Append strings to the StringBuilder
        sb.Append("Hello");
        sb.Append(", ");
        sb.Append("World!");
        
        // Insert a string at a specific position
        sb.Insert(5, " C#");

        // Replace a substring with another string
        sb.Replace("World", "StringBuilder");
        
        Console.WriteLine("SB print ");
        Console.WriteLine(sb); // Output: Hello C#, StringBuilder!
        
        for (int i = 0; i < 3; i++)
        {
            sb.Append("Line " + i + "\n");
        }

        string result = sb.ToString();
        Console.WriteLine("Hello there {0} ", result);
        
        Console.WriteLine("Param modify ------> ");
        
        double val = 10;
        string inf = "Hi";

        modify(ref val, inf);
        
        Console.WriteLine("Val: {0}, Inf: {1} ", val, inf);
    }

    private protected static void modify(ref double val, string inf)
    {
        val = 5;
        inf = "Hello";

        // val = vali;
        //
        // inf = inf2;
        
        Console.WriteLine("Val inside : {0}, Inf: {1} ", val, inf);
    }

    public virtual void LearnNoStatic(double inf)
    {
        Console.WriteLine("This is a non-static method");
    }
}
