//Create a program that can be used for calculation of 4 arithmetic operations (+, -, *, /) according to tasks:

//1) declare a delegate CalcDelegate referring to a function Calc with three parameters (two numbers and one - operation sign) and a numerical result;

//2) define a class CalcProgram and within this class:

//2.1) define a static function Calc for computation with the same signature as the delegate. Note: in case of denominator = 0, the function returns 0.

//2.2) create a public object funcCalc of delegate type and pass the function Calc as an argument.

using System;
delegate double CalcDelegate(double num1, double num2, char op);
class CalcProgram
{
    public static double Calc(double num1, double num2, char op)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num2 != 0 ? num1 / num2 : 0;
            default:
                throw new ArgumentException("Invalid operation");
        }
    }


    public CalcDelegate funcCalc = new CalcDelegate(Calc);
}
