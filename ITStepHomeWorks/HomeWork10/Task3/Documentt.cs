using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task3;

public class Documentt : IReadable, IWritable
{
    public void Read()
    {
        Console.WriteLine("document is readable!");
    }

    public void Write()
    {
        Console.WriteLine("document is writable!");
    }
}
