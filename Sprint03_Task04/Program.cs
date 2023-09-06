//using System.Runtime.Intrinsics.X86;

//Define a class IListExtensions with an extension method IncreaseWith(…) that takes an instance of a class, that implements the interface list of integers(IList<int>). Method IncreaseWith(…) increases the value of each item by a certain number. 

//Define a class IEnumerableExtensions with an extension method ToString(). ToString() loops through a collection and converts a sequence of elements (list of integers) to a meaningful string (items separated with ', ' and surrounded with '[' and ']').

//Use IncreaseWith() and ToString() extention methods in such a way:

//List<int> numbers = new List<int> { 1,2,3,4,5 };
//Console.WriteLine(numbers.ToString<int>());
//numbers.IncreaseWith(5);
//Console.WriteLine(numbers.ToString<int>());

//Output:
//[1,2,3,4,5]
//[6,7,8,9,10]

using System.Collections.Generic;
using System.Linq;
public static class IListExtensions
{
    public static void IncreaseWith(this IList<int> list, int amount)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] += amount;
        }
    }
}

public static class IEnumerableExtensions
{
    public static string ToString<T>(this IEnumerable<T> collection)
    {
        return "[" + string.Join(", ", collection) + "]";
    }
}