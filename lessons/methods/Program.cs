using System.Diagnostics;

namespace lessons.methods;

public class Program
{
    public static void learn()
    {
        Console.WriteLine("Learn about methods ");
        string a = "a";
        string b = "b";
        
        int info = b != a ? 1 : 2;
        
        Console.WriteLine(info);
        Program newCls = new Program();
        switch (info)
        {
            case 1:
                Console.WriteLine("This is case 1");
                newCls.todo();
                break;
            case 2:
                Console.WriteLine("This is case 2");
                break;
            default:
                Console.WriteLine("This is default");
                break;
        }
    }

    private void todo()
    {
        Console.WriteLine("This is a todo");
    }

}