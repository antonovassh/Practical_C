﻿//using System.Dynamic;

//Within the class ReflectorAssembly you have to:

//1) define three classes LargeBox, Box, and SmallBox. Each of them contains two static methods with string parameter size:

//-UnPackingBox() outputs in console ("I am unpacking {0} box.", size);

//-InBox() - ("I am in {0} box.", size);

//2) define two interfaces: 

//-ILookingForBox with static method LookForBox() takes string parameter;

//-IPackingBox with static method PackBox() takes a string parameter.

//3) define the static method WriteAssemblies() which contains the following logic:

//-get calling assembly;

//-get all types within the assembly;

//-iterating through the collection of types;

//-providing the output is it class, method, and name of the type;

//-all methods of the class have to be invoked with the parameter according to the name of the class.

//Note.You have to exclude classes Task and Reflector (with their methods) from the output.

//The result of the method WriteAssemblies() invoking:

using System.Reflection;
public class ReflectorAssembly
{
    public class LargeBox
    {
        public static void UnPackingBox(string size) => Console.WriteLine("I am unpacking {0} box.", size);
        public static void InBox(string size) => Console.WriteLine("I am in {0} box.", size);

    }
    public class Box
    {
        public static void UnPackingBox(string size) => Console.WriteLine("I am unpacking {0} box.", size);
        public static void InBox(string size) => Console.WriteLine("I am in {0} box.", size);
    }
    public class SmallBox
    {
        public static void UnPackingBox(string size) => Console.WriteLine("I am unpacking {0} box.", size);
        public static void InBox(string size) => Console.WriteLine("I am in {0} box.", size);
    }
    public interface ILookingForBox
    {
        public static void LookForBox(string str) { }

    }
    public interface IPackingBox
    {
        public static void PackBox(string str) { }
    }
    public static void WriteAssemblies()
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        foreach (var type in assembly.GetTypes())
        {
            if (type.Name != "Task" && type.Name != "Reflector")
            {
                Console.WriteLine($"{(type.IsClass ? "Class:" : "Interface:")} {type.Name}");
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                {
                    Console.WriteLine($"{method.MemberType}: {method.Name}");
                    if (type.IsNested)
                    {
                        Console.Write($"{method.Invoke(null, new object[] { GetValue(type.Name) })}");
                    }
                }
            }
        }
    }
    private static object GetValue(string name) => name switch
    {
        "LargeBox" => "large",
        "Box" => "middle",
        _ => "small"
    };
}