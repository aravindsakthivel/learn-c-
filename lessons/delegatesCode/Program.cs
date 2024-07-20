namespace lessons.delegatesCode;

internal class Publisher
{
    public delegate void Notify(string message);
    public event Notify? OnNotify;

    public void Publish(string message)
    {
        OnNotify?.Invoke(message);
    }
}

internal class Subscriber
{
    public void OnNotificationReceived(string message)
    {
        Console.WriteLine("Notification received: " + message);
    }
}

public class Program
{
    
    public static void PubSub()
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        publisher.OnNotify += subscriber.OnNotificationReceived;
        publisher.Publish("Hello, Subscriber!");
    }
    public static void learn()
    {
        Arithmetic add = new Arithmetic(Add);
        
        Console.WriteLine(add(2, 3));
    }

    private delegate double Arithmetic(double a, double b);
    
    private static double Add(double a, double b)
    {
        return a + b;
    }
}