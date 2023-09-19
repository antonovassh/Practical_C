//Little boy Jimmy likes his pets and is fond of programming.

//Jimmy has a cat Tom, a duck McDuck, a sparrow Sparry and a parrot Leya. Jimmy decided to write a program to have a little report about pets' habits. 

//But Leya is a very clever parrot. She knows about SOLID principles and LSP she loves most of all. She didn't like Jimmy's code. So she mixed all the classes, methods, and interfaces.

//At least Jimmy has only identifiers: Bird, Cat, Parrot, Duck, IFlyable, IEating, IMoving, Fly, Eat, Move, IBasking, IKryaking, Bask, Krya. And he remembers that every method has to output one habit of one pet.

//Please, define all the types and their members to help Jimmy to see the result as follows:

public class Bird : IFlyable, IEating, IMoving
{
    public void Fly() => Console.WriteLine("I believe, I can fly");
    public void Eat() => Console.WriteLine("Oh! My corn!");
    public void Move() => Console.WriteLine("I can jump!");
}
public class Cat : IMoving, IEating, IBasking
{
    public void Move() => Console.WriteLine("I can jump!");
    public void Eat() => Console.WriteLine("Oh! My milk!");
    public void Bask() => Console.WriteLine("Mrrr-Mrrr-Mrrr...");
}
public class Parrot : Bird, IFlyable, IBasking, IKryaking, IEating, IMoving
{
    public void Bask() => Console.WriteLine("Chuh-Chuh-Chuh...");


    public void Eat() => Console.WriteLine("Oh! My seeds and fruits!");


    public void Fly() => Console.WriteLine("I believe, I can fly");


    public void Krya() => Console.WriteLine("Krya-Krya-Krya...");


    public void Move() => Console.WriteLine("I can jump!");

}
public class Duck : Bird, IFlyable, IEating, IKryaking, IMoving
{
    public void Fly() => Console.WriteLine("I believe, I can fly");
    public void Eat() => Console.WriteLine("Oh! My corn!");
    public void Krya() => Console.WriteLine("Krya-Krya!");
    public void Move() => Console.WriteLine("I can swimm!");
}


interface IFlyable
{
    public void Fly();
}
interface IEating
{
    public void Eat();
}
interface IMoving
{
    public void Move();
}
interface IBasking
{
    public void Bask();
}
interface IKryaking
{
    public void Krya();
}