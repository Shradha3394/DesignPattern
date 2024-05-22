using System;

namespace DemoApplication.Pattern3_FactoryMethod
{
    internal class StripeGatewayCreator : PaymentGatewayCreator
    {
        public override IPaymentGateway GetPaymentGateWay()
        {
            return new Stripe();
        }
    }
}
