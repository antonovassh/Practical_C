//Implement ParallelUtils class that will be able to execute an operation in a parallel thread.



//The constructor of ParallelUtils takes 3 parameters: 

// 1) The Func<T, T, TR> to define an operation that will be executed,

// 2) The operand1 of type T 

// 3) Tperand2 of type T.

//The ParallelUtils class should have public Result property of type TR where the result of the operation must be written when it's executed.

//Implement method StartEvaluation that will start the evaluation (of the function passed into constructor) in a parallel thread 

//Implement method Evaluate that will start the evaluation (of the function passed into constructor) in a parallel thread and wait until it's executed
using System.Threading;
using System.Threading.Tasks;

public class ParallelUtils<T, TR>
{
    private T operand1;
    private T operand2;
    private Func<T, T, TR> func;

    public ParallelUtils(Func<T, T, TR> func, T operand1, T operand2)
    {
        this.func = func;
        this.operand1 = operand1;
        this.operand2 = operand2;
    }

    public TR Result { get; set; }

    public void StartEvaluation()
    {
        Thread thread = new Thread(Evaluate);
        thread.Start();
    }

    public void Evaluate() => Result = func(operand1, operand2);
}