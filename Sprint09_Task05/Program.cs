//using System.ComponentModel;

//Suppose we have a class named Calc which has a method Seq
//generating n-th member of a certain number sequence (starting from 1).

//Define a class named CalcAsync.In this class:

//Write an asynchronous static method PrintSpecificSeqElementsAsync
//taking an array of integers as a patameter,
//which performs a calculation of apropriate sequence member
//according to each number in the input array
//and prints out the result as follows:
//"Seq[X] = Y", where X is a number from input array, Y is the corresponding sequence member.
//Each calculation should be performed in a separate task.
//After last calculation is performed, the list of found exceptions should be printed.

//(The method Seq generates appropriate exception for non-positive input parameter.)

using System.Threading.Tasks;
using System.Collections.Generic;

public class CalcAsync
{
    public static async void PrintSpecificSeqElementsAsync(int[] array)
    {

        List<Task> tasks = new List<Task>();
        Task t = null;
        try
        {
            foreach (var item in array)
            {
                tasks.Add(Task.Run(() => Console.WriteLine($"Seq[{item}] = {Calc.Seq(item)}")));
            }
            t = Task.WhenAll(tasks);
            await t;
        }
        catch
        {
            foreach (var item in t.Exception.InnerExceptions)
            {
                Console.WriteLine($"Inner exception: {item.Message}");
            }
        }


    }
}