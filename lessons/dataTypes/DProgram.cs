namespace lessons.dataTypes;

using System;

/**
 * This class demonstrates the various data types in C#.
 * description Integral Types
 * `byte` - 8-bit unsigned integer
 */
class DProgram
{
    public DProgram()
    {
        // Integral Types
        byte b = 255; // 0 to 255
        sbyte sb = -128; // -128 to 127
        short s = -32768; // -32,768 to 32,767
        ushort us = 65535; // 0 to 65,535
        int i = -2147483648; // -2,147,483,648 to 2,147,483,647
        uint ui = 4294967295; // 0 to 4,294,967,295
        long l = -9223372036854775808; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong ul = 18446744073709551615; // 0 to 18,446,744,073,709,551,615

        // Floating-Point Types
        float f = 3.402823E+38F; // ±1.5e−45 to ±3.4e38
        double d = 1.7976931348623157E+308; // ±5.0e−324 to ±1.7e308

        // Decimal Type
        decimal dec = 79228162514264337593543950335M; // ±1.0e−28 to ±7.9e28

        // Other Primitive Types
        char c = 'A'; // Unicode characters, 0 to 65535
        bool isTrue = true; // true or false

        // String Type
        string str = "Hello, World!"; // A sequence of Unicode characters

        // Array Type
        int[] arr = new int[] { 1, 2, 3, 4, 5 }; // An array of integers

        // User-Defined Types
        Person person = new Person { Name = "John", Age = 30 }; // Class instance

        // Nullable Type
        int? nullableInt = null; // Nullable integer

        // Tuple
        var tuple = (1, "hello", true); // Tuple containing int, string, and bool

        // Dynamic Type
        dynamic dyn = 42; // Dynamic type
        dyn = "string";

        // Object Type
        object obj = 42; // Object type

        // Enum Type
        Days today = Days.Monday; // Enum instance

        // Struct Type
        Point point = new Point { X = 10, Y = 20 }; // Struct instance

        // Interface Type
        IExample example = new ExampleClass(); // Interface instance
        example.DoSomething();

        // Display values and limits
        Console.WriteLine($"byte: {b}, Min: {byte.MinValue}, Max: {byte.MaxValue}");
        Console.WriteLine($"sbyte: {sb}, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
        Console.WriteLine($"short: {s}, Min: {short.MinValue}, Max: {short.MaxValue}");
        Console.WriteLine($"ushort: {us}, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
        Console.WriteLine($"int: {i}, Min: {int.MinValue}, Max: {int.MaxValue}");
        Console.WriteLine($"uint: {ui}, Min: {uint.MinValue}, Max: {uint.MaxValue}");
        Console.WriteLine($"long: {l}, Min: {long.MinValue}, Max: {long.MaxValue}");
        Console.WriteLine($"ulong: {ul}, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
        Console.WriteLine($"float: {f}, Min: {float.MinValue}, Max: {float.MaxValue}");
        Console.WriteLine($"double: {d}, Min: {double.MinValue}, Max: {double.MaxValue}");
        Console.WriteLine($"decimal: {dec}, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
        Console.WriteLine($"char: {c}, Min: {char.MinValue}, Max: {char.MaxValue}");
        Console.WriteLine($"bool: {isTrue}");
        Console.WriteLine($"string: {str}");
        Console.WriteLine($"array: {string.Join(", ", arr)}");
        Console.WriteLine($"Person: {person.Name}, {person.Age}");
        Console.WriteLine($"Nullable int: {nullableInt}");
        Console.WriteLine($"Tuple: {tuple.Item1}, {tuple.Item2}, {tuple.Item3}");
        Console.WriteLine($"Dynamic: {dyn}");
        Console.WriteLine($"Object: {obj}");
        Console.WriteLine($"Enum: {today}");
        Console.WriteLine($"Struct: {point.X}, {point.Y}");
        
        // explicit conversion
        
        const double dbData = 12.334;
        int intData = (int)dbData;
        Console.WriteLine($"Data converted to interger {intData}");
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

struct Point
{
    public int X;
    public int Y;
}

interface IExample
{
    void DoSomething();
}

class ExampleClass : IExample
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}
