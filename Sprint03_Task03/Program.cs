//Define a static method ListWithPositive that receives the List of negative and positive elements as a parameter. 

//The method  ListWithPositive uses the FindAll method on the List type. The argument to FindAll will use the anonymous method syntax. The predicate in FindAll will use an evaluated boolean expression, causing the anonymous function to return true if the argument is positive and less than or equal to 10.

//The method  ListWithPositive returns the list of positive elements.

using System.Collections.Generic;
class ListProgram
{
    public static List<int> ListWithPositive(List<int> elements)
    {
        List<int> positiveElements = elements.FindAll(delegate (int num)
        {
            return num > 0 && num <= 10;
        });

        return positiveElements;
    }


}