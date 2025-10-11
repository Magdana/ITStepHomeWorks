using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task6;

public class Rectangle(double width, double height) : IShape
{
    public double GetArea()
    {
        return width * height;
    }
}
