using System.Reflection.Metadata;

//Within the class ReflectMethod you have to:

//1) define the public static class Methods with three public static methods: Hello(), Welcome() and Bye(). Each of them takes a string parameter and provides the console output of formatted string according to its name:

//("Hello:parameter={0}", parameter)

//("Welcome:parameter={0}", parameter)

//("Bye:parameter={0}", parameter)

//2) define the public static method InvokeMethod() which takes the string array as parameter. 

//The logic of the method involves:

//-to form a collection of methods from the class Methods, 

//-to iterate over this collection by the method name,

//- to invoke the method and pass it parameters from the array one by one.

//The call of InvokeMethod() provides the output as follows:
using System.Reflection;
class ReflectMethod
{
    public static class Methods
    {
        public static void Hello(string str)
        {
            Console.WriteLine(String.Format("Hello:parameter={0}", str));
        }
        public static void Welcome(string str)
        {
            Console.WriteLine(String.Format("Welcome:parameter={0}", str));
        }
        public static void Bye(string str)
        {
            Console.WriteLine(String.Format("Bye:parameter={0}", str));
        }
    }
    public static void InvokeMethod(string[] array)
    {
        Type type = typeof(Methods);
        foreach (MethodInfo info in type.GetMethods(BindingFlags.Static | BindingFlags.Public))
        {
            foreach (var item in array)
            {
                info.Invoke(type, new object[] { item });
            }
        }
    }
}
