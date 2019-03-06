using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Singleton
    {

        public String name = "asas";

        private Singleton() { }

        private static Singleton singleton = null;

        public static Singleton GetSingleton() {
            if (singleton == null) {
                singleton = new Singleton();
                singleton.vrat();
            }

            return singleton;
        }

        public void vrat() {
            
            Console.WriteLine(name);



        }

       
        










    }
}
