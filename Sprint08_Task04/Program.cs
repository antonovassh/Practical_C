//using System.Numerics;

//Please create a class MyProgram.

//Create a method Counter that takes one parameter of int type.

//This method should start two threads. 

//One of them calculates the factorial of Counter's argument (n! = 1 * 2 * ... * (n - 1) * n).

//The second thread calculates the appropriate number of Fibonaci sequence (fibo(0) = 0, fibo(1) = 1, ... fibo(n) = fibo(n - 1) + fibo(n - 2)).

//Please implement the additional methods.

//Method Counter should display two messages:

//"Factorial is: <factorial>"

//"Fibbonaci number is: <fibo>".

//The sequence of outputs matters.

//Example:

//Input: MyProgram.Counter(4);

//Output:

//Factorial is: 24

//Fibbonaci number is: 3

using System.Threading;
class MyProgram
{
    public static void Counter(int n)
    {
        Thread factorialThread = new Thread(() =>
        {
            int factorial = CalculateFactorial(n);
            Console.WriteLine($"Factorial is: {factorial}");
        });

        Thread fibonacciThread = new Thread(() =>
        {
            int fibonacci = CalculateFibonacci(n);
            Console.WriteLine($"Fibbonaci number is: {fibonacci}");
        });

        factorialThread.Start();
        Thread.Sleep(1000);
        fibonacciThread.Start();



        factorialThread.Join();
        fibonacciThread.Join();
    }

    private static int CalculateFactorial(int n)
    {
        if (n <= 1)
            return 1;

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    private static int CalculateFibonacci(int n)
    {
        if (n <= 0)
            return 0;
        if (n == 1)
            return 1;

        int prev1 = 0;
        int prev2 = 1;
        int fibo = 0;

        for (int i = 2; i <= n; i++)
        {
            fibo = prev1 + prev2;
            prev1 = prev2;
            prev2 = fibo;
        }

        return fibo;
    }
}