using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //LazySingleton();
            //MultiThreadLazySingleton();
            //Eager_Singleton();
        }


        #region Lazy Singleton
        static void LazySingleton()
        {
            Database sng = Database.Instance;
            sng.Connection("First Proccess");
            Database sng2 = Database.Instance;
            sng2.Connection("Second Proccess");
        }

        #endregion

        #region Multi Thread Lazy Singleton

        static void MultiThreadLazySingleton()
        {
            Parallel.Invoke(() => FirstProccess(), () => SecondProccess());//Parallel.Invoke() anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
            Console.ReadLine();
        }

        static void FirstProccess()
        {
            Database2 db = Database2.Instance;
            db.Connection("First Proccess");
        }
        static void SecondProccess()
        {
            Database2 db = Database2.Instance;
            db.Connection("Second Proccess");
        }

        #endregion

        #region Eager Singleton
        static void Eager_Singleton()
        {
            Parallel.Invoke(() => FirstProccess2(), () => SecondProccess2());//Parallel.Invoke() anahtar kelimesinin işlevini yazının sonundaki Keywords(buraya link koy) başlığında bulabilirsiniz
            Console.ReadLine();
        }

        static void FirstProccess2()
        {
            Database3 db = Database3.Instance;
            db.Connection("First Proccess");
        }
        static void SecondProccess2()
        {
            Database3 db = Database3.Instance;
            db.Connection("Second Proccess");
        }
        #endregion

    }
}
