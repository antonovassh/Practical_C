//Please, create a method ProductWithCondition that takes a list of integers as a parameter and returns a product of elements that satisfy a condition that is passed as a second parameter.

//The second parameter should be a Func that takes an integer as a parameter and returns bool.

//If the first parameter or result of filtering contains 0 elements the method must return 1.

//(You don't need to verify on null parameter values. Assume that parameters will always be not null)

public static int ProductWithCondition(List<int> numbers, Func<int, bool> condition)
{
    Predicate<int> predicate = new Predicate<int>(condition);
    List<int> filteredNumbers = numbers.FindAll(predicate);

    if (filteredNumbers.Count == 0)
    {
        return 1;
    }

    int product = 1;
    foreach (int num in filteredNumbers)
    {
        product *= num;
    }

    return product;
}