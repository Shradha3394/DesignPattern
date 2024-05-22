namespace DemoApplication.Pattern3_FactoryMethod
{
    internal interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
