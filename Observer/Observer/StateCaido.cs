using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class StateCaido : State
    {
        public override void Respuesta()
        {
            Console.WriteLine("Error 404");
        }
    }
}
