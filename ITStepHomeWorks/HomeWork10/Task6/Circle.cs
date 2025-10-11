using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task6;

public class Circle(double radius) : IShape
{
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
