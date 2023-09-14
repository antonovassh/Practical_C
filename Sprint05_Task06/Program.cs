//using System;

//Implement the ReverseNotebook() method that creates a new dictionary with name as key and list of phones as value.  The method receives a dictionary  with phone as key and name as value.

//For example, for a given dictionary {0967654321=Petro, 0677654321=Petro, 0501234567=Ivan, 0970011223=Stepan, 0631234567=Ivan} you should get {Ivan=[0501234567, 0631234567], Petro =[0967654321, 0677654321], Stepan =[0970011223]}.

//The method should work with entry notebook containing empty or null names without throwing exceptions. Use empty string as a key for null names.
public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phoneToName)
{
    Dictionary<string, List<string>> nameToPhones = new Dictionary<string, List<string>>();

    foreach (var pair in phoneToName)
    {
        string name = pair.Value ?? "";
        if (!nameToPhones.ContainsKey(name))
        {
            nameToPhones[name] = new List<string>();
        }
        nameToPhones[name].Add(pair.Key);
    }

    return nameToPhones;
}