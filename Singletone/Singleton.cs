using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public sealed class Singleton
    {
        public static int i; //check instances
        #region normal scenation
        /*
        private static Singleton Instance = null;//create a instance
        private static readonly object obj = new object();//yo use lock
        */
        #endregion
        #region eager loading 
       // private static Singleton eagerInstance = new Singleton();//create a instance
        #endregion
        #region lazy Laoding 
        private static Lazy<Singleton> lazyInstance = new Lazy<Singleton> (()=>new Singleton());//create a instance of lazy loading they are thread safe by default.
        #endregion
        public static Singleton getInstance //create property for singleton Instance
        {
            get 
            {
                #region normal scenation
                /*
                if (Instance == null)
                { 
                    lock (obj)//to rum 1 instance
                {
                    if (Instance == null)
                        Instance = new Singleton();
                }
                }
                return Instance;*/
                #endregion
                #region eagerLoding
              //  return eagerInstance;
                #endregion
                #region LazyLoding
                return lazyInstance.Value;
                #endregion 

            }

        }
        private  Singleton()
        {
            i++;
            Console.WriteLine("Counter "+i.ToString());
            

        }
        public void printMsg(string Messga)
           {
            Console.WriteLine(Messga);
        }
    }
}
