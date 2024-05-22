using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Pattern3_FactoryMethod
{
    internal abstract class PaymentGatewayCreator
    {
       public abstract IPaymentGateway GetPaymentGateWay();
    }
}
