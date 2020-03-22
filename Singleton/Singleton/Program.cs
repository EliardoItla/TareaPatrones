using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Singleton.Instance.msj);
            Singleton.Instance.msj = "Tipico Gurabo";
            Console.WriteLine(Singleton.Instance.msj);
        }
    }
}
