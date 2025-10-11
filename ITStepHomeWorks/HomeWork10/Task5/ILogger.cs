using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task5;

public interface ILogger
{
    void Log(string message);
    void LogWithTime(string message)
    {
        Console.WriteLine($"WARNING: {message}. time: {DateTime.Now}");
    }
}
