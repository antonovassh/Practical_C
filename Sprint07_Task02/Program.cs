//using System.Reflection.Metadata;

//Please, implement EvaluateAggregate method that takes 

//     an array of doubles as the first parameter,

//     a delegate that defines an aggregate behavior as the second,

//     a delegate that defines a condition for the index as the third parameter.

//The method should return a result of an aggregate operation for the elements with indexes that satisfy the condition set by the third parameter

//(You don't need to verify on null parameter values. Assume that parameters will always be not null)
public static double EvaluateAggregate(double[] array, Func<double, double, double> aggregateDelegate, Func<double, int, bool> conditionDelegate)
{
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (conditionDelegate(array[i], i))
        {
            result = aggregateDelegate(result, array[i]);
        }
    }

    return result;
}