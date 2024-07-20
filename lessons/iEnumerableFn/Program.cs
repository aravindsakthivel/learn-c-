using System; 
using System.Collections;

namespace lessons.iEnumerableFn;

public class Program
{
    public static void learn()
    {
        StudentCollection collection = new StudentCollection();  
        collection.Add(new Student { Name = "John Doe", Age = 20 });  
        collection.Add(new Student { Name = "Jane Smith", Age = 22 });  
        collection.Add(new Student { Name = "Alex Johnson", Age = 21 }); 
        
        foreach (var student in collection)  
        {  
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");  
        }  
    }  
    
}


  
public class Student  
{  
    public string Name { get; set; }  
    public int Age { get; set; }  
}  
  
public class StudentCollection : IEnumerable  
{  
    private List<Student> students = new List<Student> ();  
  
    public void Add (Student student)  
    {  
        students.Add(student);  
    }  
  
    public IEnumerator<Student> GetEnumerator()  
    {  
        Console.WriteLine("IEnumerator<Student> GetEnumerator() called. ");
        return students.GetEnumerator();  
    }  
  
    IEnumerator IEnumerable.GetEnumerator()
    {
        Console.WriteLine("IEnumerable.GetEnumerator() called. ");
        return GetEnumerator();
    }
}  