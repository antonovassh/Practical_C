//Please, implement the SumOfElementsOddPositions method that returns sum of elements with odd indexes in the array of doubles

//(You don't need to verify on null parameter value. Assume that parameter will always be not null)
public static double EvaluateSumOfElementsOddPositions(double[] inputData)
{

    double sum = 0;

    for (int i = 1; i < inputData.Length; i += 2)
    {
        sum += inputData[i];
    }

    return sum;


}