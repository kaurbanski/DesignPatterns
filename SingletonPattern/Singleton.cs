using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton singleton = null;
        private readonly static object locker = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            lock (locker)
            {
                if (singleton == null)
                {
                    singleton = new Singleton();
                }
                return singleton;
            }
        }
    }
}
