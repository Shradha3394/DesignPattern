using System;

namespace DemoApplication.Pattern3_FactoryMethod
{
    internal class PaypalGatewayCreator : PaymentGatewayCreator
    {
        public override IPaymentGateway GetPaymentGateWay()
        {
            return new Paypal();
        }
    }
}
