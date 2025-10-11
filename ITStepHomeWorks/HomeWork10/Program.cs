using HomeWork10.Task1;
using HomeWork10.Task2;
using HomeWork10.Task3;
using System.Reflection.Metadata;



//Task 1: Create and Implement an Interface

List<IAnimal> animals = new List<IAnimal>();
animals.Add(new Dog());
animals.Add(new Cat());
foreach (var animal in animals)
{
    animal.MakeSound(); 
}



//Task 2: Interface with Properties
Car newCar = new("Toyota", 2020);
newCar.Start();



//Task 3: Multiple Interfaces

Documentt document = new Documentt();
document.Read();
document.Write();
