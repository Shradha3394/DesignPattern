using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication.Pattern1_Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object LockObj = new object();

        private Singleton() {}

        public static Singleton Instanse
        {
            get
            {
                if (_instance == null)
                {
                    lock (LockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
