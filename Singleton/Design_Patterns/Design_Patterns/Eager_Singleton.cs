using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    sealed class Database3 //sealed anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
    {
        private static Database3 _instance = new Database3(); // null anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz

        private Database3() { Console.WriteLine("Instance created"); }
        public static Database3 Instance
        {
            get { return _instance; }
        }

        public void Connection(string Name)
        {
            Console.WriteLine("{0} has connected", Name);
        }
    }

}
