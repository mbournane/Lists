using System.Collections.Generic;
namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        List<string> strCollection = new List<string>();
        strCollection.Add("Lion");
        strCollection.Add("Lapin");
        strCollection.Add("Elephant");

        strCollection.RemoveAt(0);
        strCollection.Remove("Elephant");
        strCollection[0]= "Chat";

        foreach(var str in strCollection)
            Console.WriteLine(str);        
    }
}
