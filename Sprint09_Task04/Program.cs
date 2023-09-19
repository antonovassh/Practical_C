using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

//Suppose we have a class named Calc which has a method Seq
//generating n-th member of a certain number sequence (starting from 1).

//Define a class named CalcAsync.In this class:

//Write an asynchronous stream called SeqStreamAsync taking integer parameter n,
//that returns a collection of n tuples
//consisting of a number i (from 1 to n) and i-th member of the sequence.

//Write an asynchronous static method PrintStream
//taking an asynchronous stream of tuples consisting of 2 integer numbers,
//which prints the collection as follows:
//"Seq[X] = Y", where X is the first item of a tuple, Y is the second one.

sing System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

 public class CalcAsync
{
    public static async IAsyncEnumerable<(int firstItem, int secondItem)> SeqStreamAsync(int number)
    {
        for (int i = 0; i < number; i++)
        {
            yield return (firstItem: i + 1, secondItem: await Task.Run(() => Calc.Seq(i + 1)));

        }
    }
    public static async void PrintStream(IAsyncEnumerable<(int firstItem, int secondItem)> tuple)
    {
        await foreach (var number in tuple)
        {
            Console.WriteLine($"Seq[{number.firstItem}] = {number.secondItem}");
        }
    }
}