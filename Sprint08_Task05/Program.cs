//using System.Threading;

//You have MyThreads class in the answer window below. Please, investigate it: there is some problem with this class.

//Fix the problem.



//    The test starts both threads with the code:

//            MyThreads.Thread1.start();
//MyThreads.Thread2.start();


//The goal of each thread is to make some evaluations, update m and n fields and not switch between threads while loop is executed.



//    You need to get an output like this:



//    Thread1 n = 0
//    Thread1 n = 1
//    Thread1 n = 2
//    Thread1 n = 3
//    Thread1 n = 4
//    Thread2 m = 0
//    Thread2 m = 1
//    Thread2 m = 2
//    Thread2 m = 3
//    Thread2 m = 4
//    Thread2 n = 5
//    Thread2 n = 6
//    Thread2 n = 7
//    Thread2 n = 8
//    Thread2 n = 9
//    Thread2 success!
//    Thread1 m = 5
//    Thread1 m = 6
//    Thread1 m = 7
//    Thread1 m = 8
//    Thread1 m = 9
//    Thread1 success!
//    Please, don't change actions that change variables or print output within run() methods. Use only thread synchronization assets.
using System.Threading;

class MyThreads
{
    public static readonly object Den = new object();
    public static readonly object Ada = new object();

    public static int n;
    public static int m;

    public Thread Thread1;
    public Thread Thread2;

    public MyThreads()
    {
        Thread1 = new Thread(Thread1Method);
        Thread2 = new Thread(Thread2Method);
    }

    private void Thread1Method()
    {
        lock (Den)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread1 n = " + n);
                n++;
            }
        }

        lock (Ada)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread1 m = " + m);
                m++;
            }
            Console.WriteLine("Thread1 success!");
        }
    }

    private void Thread2Method()
    {
        lock (Ada)
        {
            lock (Den)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Thread2 m = " + m);
                    m++;
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Thread2 n = " + n);
                    n++;
                }
                Console.WriteLine("Thread2 success!");
            }
        }
    }
}