using System;

namespace lessons.userInput
{
    public class Prg
    {
        public Prg()
        {
            Console.WriteLine("Hi There add you're input");

            string name = Console.ReadLine();
            
            Console.WriteLine($"Hi {name}");
        }
    }
}