//Within the class, ShowPowerRange create a static method PowerRanger() that takes in integer degree, start, finish. 

//The method returns all the numbers from the range [start, finish] (inclusive and finish > 0 and start > 0) that are equal to the degree-th power of any positive integer.

//In the case start > finish, or start < 0, or finish < 0 the method returns 0.

//The method involves yielding the intermediate result on each iteration.


//For example, when calling the method PowerRanger():

class ShowPowerRange
{
    public static IEnumerable<double> PowerRanger(int degree, int start, int finish)
    {
        if (start > finish || start < 0 || finish < 0)
        {
            yield return 0;
        }
        else if (degree == 0)
        {
            yield return 1;
        }
        else if (degree < 0)
        {
            yield return 0;
        }
        else
        {
            double currentNumber = 1;
            double currentPower = 1;

            while (currentPower <= finish)
            {
                if (currentPower >= start)
                {
                    yield return currentPower;
                }

                currentNumber++;
                currentPower = (double)Math.Pow(currentNumber, degree);
            }
        }

    }
}