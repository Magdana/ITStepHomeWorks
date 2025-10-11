using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.Task4;

public class PayPalPayment: IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("your PayPal payment of " + amount + " has been processed.");
    }
}
