using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task2;

public interface IVehicle
{
    string Model { get; set; }
    int Year { get; set; }
    void Start();
}
