using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoApplication.Pattern1_Singleton;

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

            Task t1 = Task.Run(() =>
            {
                s1 = Singleton.Instanse;
            });
            tasks.Add(t1);

            Task t2 = Task.Run(() =>
            {
                s2 = Singleton.Instanse;
            });
            tasks.Add(t2);

            Task.WaitAll(tasks.ToArray());

            Console.WriteLine(s1 == s2 ? "Only one instance exist" : "Multiple instance exist");
            #endregion
        }
    }
}
