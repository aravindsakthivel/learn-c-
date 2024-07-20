namespace lessons.ArraysDS;


public class Program
{
    public static void learn()
    {
        string[] fxStrArr = new string[5] {"a", "b", "c", "d", "e"};
        string[] strArr = new string[] {"a", "b", "c", "d", "e", "f"};
        var ntArr = new[] {"a", "b", "c", "d", "e", "f"};
        object[] objArr = {1, "a", 2, "b", 3, "c"};
        
        for (int j = 0; j < strArr.Length; j++)
        {
            Console.WriteLine(strArr[j]);
        }
        
        string[,] mdArr = new string[,] {{"a", "b"}, {"c", "d"}, {"e", "f"}};
        
        Console.WriteLine(mdArr[0,1]);
        Console.WriteLine("Hi {0}", mdArr.GetValue(1, 1));

        foreach (string val in strArr)
        {
            Console.WriteLine(@"Value: 
                              This is the second line
                              This is the third line {0}", val);
        }
        
        ntArr.SetValue("z", 2);
        
        Console.WriteLine(ntArr[2]);
    }
}