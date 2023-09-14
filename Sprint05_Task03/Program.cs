//using System.Numerics;

//We have the next collection:  

//Dictionary<string, string> persons = new Dictionary<string, string>();
//{
//    persons.Add("id11111", "Admin");
//    persons.Add("id12345", "User1");
//    persons.Add("id98765", "User2");
//    persons.Add("id56743", "User3");
//    persons.Add("id73920", "User4");
//}
//1) In class MyProgram please create a method that should take a collection of arguments SearchKeys(Dictionary<string, string> persons) in which print all keys from this collection

//2) method that should take a collection of arguments SearchValues(Dictionary<string, string> persons) in which print all values from this collection

//3) and method that should take a collection of arguments SearchAdmin(Dictionary<string, string> persons) in which search value "Admin" and print information in format Key + " " + Value 
public class MyProgram
{
    public static void SearchKeys(Dictionary<string, string> persons)
    {
        foreach (var key in persons.Keys)
        {
            Console.WriteLine(key);
        }
        Console.WriteLine();
    }

    public static void SearchValues(Dictionary<string, string> persons)
    {
        foreach (var value in persons.Values)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
    }

    public static void SearchAdmin(Dictionary<string, string> persons)
    {
        foreach (var pair in persons)
        {
            if (pair.Value == "Admin")
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
        Console.WriteLine();
    }
}
