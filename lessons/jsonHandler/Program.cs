namespace lessons.jsonHandler;
using System.Text.Json;

public class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static void learn()
    {
        Person person = new Person { Name = "John Doe", Age = 30 };

        // Serialize the person object to a JSON string
        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine("Serialized JSON string:");
        Console.WriteLine(jsonString);

        // Deserialize the JSON string back to a Person object
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine("Deserialized Person object:");
        Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
    }
}


