using System;

namespace DemoApplication.Pattern2_Prototype
{
    public abstract class BasicCar
    {
        public string Brand { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public int Price { get; set; }

        public static int SetPrice()
        {
           return new Random().Next(200000, 500000);
        }

        public abstract BasicCar Clone();
    }
}
