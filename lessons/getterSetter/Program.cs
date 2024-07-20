namespace lessons.getterSetter;

public class Program
{

    private static string sound;

    private string soundPrv;
    struct MyStruct
    {
        private int _myField;
        public int MyProperty
        {
            get => _myField;
            set => _myField = value;
        }
    }

    public static void learnStruct()
    {
        MyStruct myStruct = new MyStruct();
        myStruct.MyProperty = 10;
        Console.WriteLine(myStruct.MyProperty);
    }

    public static void learn()
    {
        Console.WriteLine("Learn about getter and setter ");
        Sound = "Hello";
        string getSound = Sound;
        
        Owner = "Hi";
        
        string getOwner = Owner;
        
        Console.WriteLine("Sound: {0}, Owner: {1} ", getSound, getOwner);
    }

    public static string Sound
    {
        get { return sound; }
        
        set { sound = value; }
    }
    
    public string SoundPrv
    {
        get { return soundPrv; }
        
        set { soundPrv = value; }
    }
    
    public static string Owner { get; set; }
    
}