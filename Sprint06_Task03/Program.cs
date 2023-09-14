//Inside a class ShowPower define a static method SuperPower(). SuperPower() has two integer input parameters: number and degree. The method will  calculate the power of a given number according to degree parameter.

//Note: Don't use Pow().

//The method involves to yield the intermediate result of the calculation on the each iteration.

//For example, when calling the method SuperPower():
class ShowPower
{
    public static IEnumerable<double> SuperPower(double number, int degree)
    {
        double bufer = 1;

        if (degree == 0)
        {
            yield return 1;
        }
        else if (degree > 0)
        {
            for (int i = 0; i < degree; i++)
            {
                bufer *= number;

                yield return bufer;
            }
        }
        else if (degree < 0)
        {

            for (int i = 0; i > degree; i--)
            {

                for (int j = 0; j >= i; j--)
                {
                    bufer *= number;
                }

                yield return 1 / bufer;

                bufer = 1;
            }
        }

        yield break;
    }
}