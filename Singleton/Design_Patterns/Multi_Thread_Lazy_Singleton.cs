using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    sealed class Database2 //sealed anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
    {
        private static Database2 _instance = null; // null anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
        private static readonly object threadSafety = new object(); //readonly anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz

        private Database2() { Console.WriteLine("Instance created"); }
        public static Database2 Instance
        {
            get
            {
                lock (threadSafety) //lock anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
                {
                    if (_instance == null)
                    {
                        _instance = new Database2();
                    }
                    return _instance;
                }
            }
        }
        public void Connection(string Name)
        {
            Console.WriteLine("{0} has connected", Name);
        }
    }

}
