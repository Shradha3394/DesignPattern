using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication.Pattern2_Prototype
{
    public class Nano : BasicCar
    {
        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone();
        }
    }
}
