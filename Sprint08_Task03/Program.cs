using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

public class MyTasks
{

    public static void Tasks()
    {
        int[] sequence_array = new int[10];

        Task task1 = new Task(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                sequence_array[i] = i * i;
            }
            Console.WriteLine("Calculated!");
        });

        Task task2 = new Task(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bye!");
        });

        Task task3 = new Task(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(sequence_array[i]);
            }
            Console.WriteLine("Bye!");
        });

        task1.Start();
        Task.WaitAny(task1);
        task2.Start();
        Task.WaitAny(task2);
        task3.Start();
        Task.WaitAny(task3);

        Console.WriteLine("Main done!");
    }
}
