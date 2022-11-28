using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonTest();
        }

        static void SingletonTest()
        {
            var log = Log.Instance;
            log.Save("test1");
            log.Save("test2");

            //Verificamos que sea exactamente el mismo objeto
            var a = Singleton.Singleton.Instance;
            var b = Singleton.Singleton.Instance;
            Console.WriteLine(
                    a == b
                        ? "they are the same object"
                        : "they are different objects"
                );
        }
    }
}
