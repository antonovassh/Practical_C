//using System;

//Implement the CreateNotebook() method that creates a new lookup with name as key and collection of phones as values. The method receives a dictionary with a phone as a key and a name as value.

//For example, for a given dictionary {0967654321=Petro, 0677654321=Petro, 0501234567=Ivan, 0970011223=Stepan, 0631234567=Ivan} you should get {Ivan=[0501234567, 0631234567], Petro =[0967654321, 0677654321], Stepan =[0970011223]}.

//The method should work with an entry notebook containing empty or null names without throwing exceptions. Use empty string as a key for null names.

public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
{
    return (Lookup<string, string>)phonesToNames.ToLookup(p => {
        if (p.Value is null)
            return string.Empty;

        return p.Value;
    }, p => p.Key);
}