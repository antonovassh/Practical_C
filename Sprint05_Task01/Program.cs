//In class MyProgram :
//  1) Create a method that should take a collection of arguments Position(List<int> numbers) in which find and Console.WriteLine all positions of element 5 in this collection

//  2) Create a method that should take a collection of arguments Remove(List<int> numbers) in which remove from collection all elements, which are greater than 20. and print collection

//  3) Create a method that should take a collection of arguments Insert(List<int> numbers)  in which insert elements -5,-6,-7 in positions 3, 6, 8 and print collection

//  4) Create a method that should take a collection of arguments Sort(List<int> numbers) in which sorting collection and print collection
class MyProgram
{
    public static void Position(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 5)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
        Console.WriteLine();
    }

    public static void Remove(List<int> numbers)
    {
        numbers.RemoveAll(num => num > 20);
        PrintCollection(numbers);
    }

    public static void Insert(List<int> numbers)
    {
        numbers.Insert(2, -5);
        numbers.Insert(5, -6);
        numbers.Insert(7, -7);
        PrintCollection(numbers);
    }

    public static void Sort(List<int> numbers)
    {
        numbers.Sort();
        PrintCollection(numbers);
    }

    public static void PrintCollection(List<int> numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write($"{num}\n");
        }
    }
}
