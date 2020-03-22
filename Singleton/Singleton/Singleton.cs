using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;

        public string msj = "";

        protected Singleton() {
            msj = "El Tipico Hola Mundo xD";
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}
