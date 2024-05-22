using System;

namespace DemoApplication.Pattern3_FactoryMethod
{
    internal class Stripe : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} through Stripe.");
        }
    }
}
