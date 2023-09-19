//using System.ComponentModel;

//Suppose we have a class named Calc which has a method Seq
//generating n-th member of a certain number sequence (starting from 1).

//Define a class named CalcAsync.In this class:

//Write an asynchronous static method SeqAsync taking integer parameter n,
//that returns n-th member of the sequence.
//Use Task<> as a return type.

//Write an asynchronous static method PrintSeqElementsConsequentlyAsync
//taking integer parameter quant,
//which calls SeqAsync method for each integer number i from 1 to quant
//and prints the result as follows:
//"Seq[X] = Y", where X is i, Y is the i-th sequence member.

//Write an asynchronous static method PrintSeqElementscaInParallelAsync
//taking integer parameter quant,
//which does the same as previous one, except of the way of calling SeqAsync method.
//Each call of this method should be performed so that
//it would run in parallel, not waiting for previous one.
//After the last member is received, the results should be printed as described before.

//Write the auxiliary method GetSeqAsyncTasks that will be used in the previous one.
//This method should take integer parameter n and return an array of Task<> objects.
//Each of those tasks should be responsible for geting one sequence member.
using System.Collections.Generic;
using System.Threading.Tasks;

public static class CalcAsync
{
    public static async Task<int> SeqAsync(int n)
    {
        return await Task.Run(() =>
        {
            Calc calc = new Calc();
            return Calc.Seq(n);
        });
    }
    public async static void PrintSeqElementsConsequentlyAsync(int quant)
    {
        for (int i = 1; i <= quant; i++)
        {
            int result = await SeqAsync(i);
            Console.WriteLine($"Seq[{i}] = {result}");
        }
    }
    public static async void PrintSeqElementsInParallelAsync(int quant)
    {
        var task = GetSeqAsyncTasks(quant);
        for (int i = 0; i < task.Length; i++)
        {
            await Task.Run(() => Console.WriteLine($"Seq[{i + 1}] = {task[i].Result}"));
        }
    }
    public static Task<int>[] GetSeqAsyncTasks(int quant)
    {
        Task<int>[] tasks = new Task<int>[quant];

        for (int i = 1; i <= quant; i++)
        {
            tasks[i - 1] = SeqAsync(i);
        }

        return tasks;
    }
}
