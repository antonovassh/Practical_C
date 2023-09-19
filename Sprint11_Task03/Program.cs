//Within the class ReflectProperties you have to:
//1) create public class TestProperties with four properties:
//- public string FirstName;
//- internal string LastName;
//- protected int Age;
//- private string PhoneNumber.
//2) define a static method WriteProperties() that contains logic:
//-form the collection of the properties of TestProperties class;
//-iterate through the collection;
//-provide the console output of the name, type, read/write ability, and accessibility level of every property.
//The invoke of WriteProperties() method will cause the result:

using System.Reflection;


public class ReflectProperties
{
    public class TestProperties
    {

        public string FirstName { get; set; }
        internal string LastName { get; set; }
        protected int Age { get; set; }
        private string PhoneNumber { get; set; }

    }
    public static void WriteProperties()
    {

        PropertyInfo[] myPropertyInfo;
        myPropertyInfo = typeof(TestProperties).GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

        foreach (PropertyInfo property in myPropertyInfo)
        {

            Console.WriteLine(String.Format("Property name: {0} \nProperty type: {1} \nRead-Write:    {2} \nAccessibility: {3} \n",
                property.Name, property.PropertyType.FullName, property.CanWrite, property.GetMethod.GetStringAccessmodifier()));
        }
    }

}

public static class MethodInfoExtensions
{
    public static string GetStringAccessmodifier(this MethodInfo methodInfo)
    {
        if (methodInfo.IsPrivate)
            return "Private";
        if (methodInfo.IsFamily)
            return "Protected";
        if (methodInfo.IsFamilyOrAssembly)
            return "ProtectedInternal";
        if (methodInfo.IsAssembly)
            return "Internal";
        if (methodInfo.IsPublic)
            return "Public";
        return "Did not find access modifier";
    }
}