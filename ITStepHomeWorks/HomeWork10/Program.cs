//Task 1: Create and Implement an Interface

List<IAnimal> animals = new List<IAnimal>();
animals.Add(new Dog());
animals.Add(new Cat());
foreach (var animal in animals)
{
    animal.MakeSound(); 
}

public interface IAnimal
{
    void MakeSound();
}  
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}