using HomeWork10.Task1;
using HomeWork10.Task2;
using HomeWork10.Task3;
using HomeWork10.Task4;
using HomeWork10.Task5;
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



//Task 3: Multiple Interface
Documentt document = new Documentt();
document.Read();
document.Write();


//Task 4: Payment System

Console.WriteLine("choose a payment method: \n 1. Credit Card \n 2. PayPal");
int choice = int.Parse(Console.ReadLine());
IPaymentProcessor paymentProcessor = choice switch
{
    1 => new CreditCardPayment(),
    2 => new PayPalPayment(),
    _ => throw new ArgumentException("Invalid payment method.")
};
paymentProcessor.ProcessPayment(100.00m);


//Task 5: Interface with Default Implementation (C# 8+)

ConsoleLogger consoleLogger = new ConsoleLogger();
consoleLogger.Log("This is a log message.");
consoleLogger.LogWithTime("This is a log message with time");