using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApplication.Pattern1_Singleton;
using DemoApplication.Pattern2_Prototype;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Singleton Pattern
            Singleton s1, s2;
            s1 = s2 = null;
            var tasks = new List<Task>();

            var t1 = Task.Run(() =>
            {
                s1 = Singleton.Instanse;
            });
            tasks.Add(t1);

            var t2 = Task.Run(() =>
            {
                s2 = Singleton.Instanse;
            });
            tasks.Add(t2);

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine(s1 == s2 ? "Only one instance exist" : "Multiple instance exist");
            #endregion

            #region Prototype Pattern
            var basicCar = new Nano(){Brand = "Nano", Price = 100000, Engine = "1440 CC", Transmission = "Mannual"};

            var car1 = basicCar.Clone();
            car1.Price = basicCar.Price + BasicCar.SetPrice();
            car1.Transmission = "Automatic";

            var car2 = car1.Clone();
            car2.Engine = "1668 CC";
            car2.Price = car1.Price + BasicCar.SetPrice();
            #endregion
        }
    }
}
