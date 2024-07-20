namespace lessons.dictionary;

public class Program
{
    public static void learn()
    {
        try
        {
            Dictionary<int, string> inDic = new Dictionary<int, string>();

            inDic.Add(1, "One");

            inDic.Add(2, "Two");
            // string val;
            inDic.TryGetValue(1, out string val);
            
            Console.WriteLine("Value: " + val);

            Console.WriteLine(inDic[1]);

            foreach (KeyValuePair<int, string> inItem in inDic)
            {
                Console.WriteLine("Key: " + inItem.Key + " Value: " + inItem.Value);
            
            
                
            }
        }
        catch (System.ArgumentException ex)
        {
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }
}