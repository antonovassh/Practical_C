using System.Diagnostics.Metrics;

//We have the class MainThreadProgram. Please create three methods: Calculator, Product, and Sum.

//Method Sum() should ask the user to enter 5 numbers in the form “Enter the 1st number:”, “Enter the 2nd number:” etc.and calculate their sum. After that, it should output the message “Sum is: < sum >”. 

//Method Product() should generate a List of 10 consequent integer numbers from 1 to 10 and calculate their product. Then it should wait for 10 seconds. After that, it should output the message “Product is: < product >”. 

//The Calculator() method should create two threads: productThread and sumThread, and call the Product and Sum methods in appropriate threads. This method should return a tuple of two threads: (sumThread, productThread).

using System.Collections.Generic;
using System.Threading;
using System.Linq;



public class MainThreadProgram
{
    public static (Thread, Thread) Calculator()
    {
        Thread sumThread = new Thread(Sum);
        Thread productThread = new Thread(Product);

        sumThread.Start();
        productThread.Start();

        return (sumThread, productThread);
    }

    public static void Product()
    {
        var numbers = new List<int>();
        numbers = Enumerable.Range(1, 10).ToList();

        int mult = 1;

        foreach (int i in numbers)
            mult = mult * i;

        Thread.Sleep(10000);

        Console.WriteLine($"Product is: {mult}");
    }
    public static void Sum()
    {
        Console.WriteLine("Enter the 1st number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 3rd number:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 4th number:");
        int number4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 5th number:");
        int number5 = Convert.ToInt32(Console.ReadLine());

        int result = number1 + number2 + number3 + number4 + number5;
        Console.WriteLine($"Sum is: {result}");

    }
}