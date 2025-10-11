using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task5;

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"WARNING: {message}");
    }
    public void LogWithTime(string message)
    {
        Console.WriteLine($"WARNING: {message}. time: {DateTime.Now}");
    }
}
