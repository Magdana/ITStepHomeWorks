using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task2;

public class Car : IVehicle
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }
    public void Start()
    {
        Console.WriteLine($"The car {Model} from {Year} is starting.");
    }
}
