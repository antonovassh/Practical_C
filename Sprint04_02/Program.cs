//Define an interface IAnimal with property Name, methods Voice() and Feed()

//Define two classes Cat and Dog, which implement this interface.

//For the class Dog,
//the Voice() method should print "Woof" on the Console,
//the Feed() method should print "I eat meat" on the Console.

//For the class Cat,

//the Voice() method should print "Mew" on the Console,
//the Feed() method should print "I eat mice" on the Console.
interface IAnimal
{
    string Name { get; set; }
    int LifeDuration { get; set; }

    void Voice();
    void Feed();
    void Run();
    void Stop();
    void Play();
}
public class Cat : IAnimal
{
    public string Name { get; set; }
    public int LifeDuration { get; set; }

    public void Voice()
    {
        Console.WriteLine("Mew");
    }
    public void Feed()
    {
        Console.WriteLine("I eat mice");
    }
    public void Run()
    {
        Console.WriteLine("Cat is running!");
    }
    public void Stop()
    {
        Console.WriteLine("Cat has stopped.");
    }
    public void Play()
    {
        Console.WriteLine("Cat is playing with toy-mouse");
    }

}
public class Dog : IAnimal
{
    public string Name { get; set; }
    public int LifeDuration { get; set; }
    public void Voice()
    {
        Console.WriteLine("Woof");
    }
    public void Feed()
    {
        Console.WriteLine("I eat meat");
    }
    public void Run()
    {
        Console.WriteLine("Dog is running!");
    }
    public void Stop()
    {
        Console.WriteLine("Dog has stopped.");
    }
    public void Play()
    {
        Console.WriteLine("Dog is playing with a ball");
    }
}