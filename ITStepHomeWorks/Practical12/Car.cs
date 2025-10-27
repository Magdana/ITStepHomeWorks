using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical12;

public class Car
{
    public string Make { get; set; }= string.Empty;
    public string Model { get; set; }= string.Empty;
    public int Cylinder { get; set; }
    public double Engine { get; set; }
    public string Drive { get; set; }= string.Empty;
    public string Transmission { get; set; }= string.Empty;
    public int MileageInCity { get; set; }
    public int MileageInHwy { get; set; }
    public int CombinedMileage { get; set; }
}
