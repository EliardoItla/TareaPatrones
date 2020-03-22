using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StateSaturado : State
    {
        public override void Respuesta()
        {
            Task.Delay(2000);
            Console.WriteLine("200");
        }
    }
}
