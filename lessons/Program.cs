// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
// Console.WriteLine("Press any key to continue...");

// UserInput.Prg newCls = new UserInput.Prg();


// using lessons.userInput;
//
// namespace lessons
// {
//     public class Program()
//     {
//         public static void Main(string[] args)
//         {
//             var newCls = new Prg();
//         }
//     }
//
// }


using lessons.dataTypes;
using lessons.nameSpaceHandler;
public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hi There add you're input pls");

        string name = Console.ReadLine();
        
        Console.WriteLine($"Hi {name}");
        
        // DProgram newPr = new DProgram();
        
        string frString = String.Format("Hi {0} and info ", name);
        
        Console.WriteLine(frString);
        
        lessons.ArraysDS.Program.learn();
        
        lessons.methods.Program.learn();
        
        lessons.exceptionHandler.Program.learn();
        
        lessons.stringBuilder.Program.learn();
        
        lessons.getterSetter.Program.learn();
        
        lessons.arrayLists.Program.learn();
        
        lessons.dictionary.Program.learn();
        
        lessons.queue.Program.learn();
        
        lessons.stacks.Program.learn();
        
        NSpaceOne.learn();
        
        NewCls.NewMethod();
        
        lessons.versionCode.Program.learn();
        
        lessons.versionCode.Program.test();
        
        lessons.delegatesCode.Program.learn();
        
        lessons.delegatesCode.Program.PubSub();
        
        lessons.lambdaFn.Program.learn();
        
        lessons.operatorOverloading.Program.learn();
        
        lessons.iEnumerableFn.Program.learn();
        
        lessons.threads.Program.learn();

        await lessons.tasks.Program.learn();
        
        lessons.jsonHandler.Program.learn();
    }
}