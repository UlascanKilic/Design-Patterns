using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns
{
    sealed class Database //sealed anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
    {
        private static Database _instance = null; // null anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
        private Database() { Console.WriteLine("Instance created"); }
        public static Database Instance
        {
            get
            {
                if (_instance == null) //_instance null mu ?
                {
                    _instance = new Database(); // Eğer null ise yeni bir nesne oluştur.
                }
                return _instance; // _instance’yi geri döndür.
            }
        }
        public void Connection(string Name)
        {
            Console.WriteLine("{0} has connected", Name);
        }
    }

}
