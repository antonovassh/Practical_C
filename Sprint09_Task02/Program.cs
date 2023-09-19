//using System.ComponentModel;

//Suppose we have a class named Calc which has a method Seq
//generating n-th member of a certain number sequence (starting from 1).

//Define a class named CalcAsync.In this class:

//Write an asynchronous static method TaskPrintSeqAsync taking integer parameter n,
//that prints out the following:
//"Seq[X] = Y", where X is the value of input parameter n, Y is n-th member of the sequence.
//Use Task as return type

//Implement an extention method named PrintStatusIfChanged
//which takes, as parameters, a task along with its previous status,
//prints out the status if it was changed, and updates the old one (given by the parameter).

//Implement an extention method named TrackStatus which takes, as a parameter, a task,
//and continuously checks a status of the task, and prints out its status if changed.
using System.Threading.Tasks;

public static class CalcAsync
{
    public static async Task TaskPrintSeqAsync(int n)
    {
        await Task.Run(() =>
        {
            Calc calc = new Calc();
            int result = Calc.Seq(n);
            Console.WriteLine($"Seq[{n}] = {result}");
        });
    }
    public static void PrintStatusIfChanged(this Task task, ref TaskStatus previosTaskStatus)
    {
        if (task.Status > previosTaskStatus)
        {
            previosTaskStatus = task.Status;
            Console.WriteLine(task.Status);
        }
    }

    public static void TrackStatus(this Task task)
    {
        TaskStatus taskStatus = TaskStatus.Created;
        while (taskStatus != TaskStatus.RanToCompletion)
        {
            task.PrintStatusIfChanged(ref taskStatus);
        }
    }
}
