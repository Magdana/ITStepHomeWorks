using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task4;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
