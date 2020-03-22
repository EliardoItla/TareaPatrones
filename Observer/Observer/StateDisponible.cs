using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class StateDisponible : State
    {
        public override void Respuesta()
        {
            Console.WriteLine("200");
        }
    }
}
