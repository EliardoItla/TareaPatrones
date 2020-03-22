using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class StateSuperSaturado : State
    {
        public override void Respuesta()
        {
            Task.Delay(4000);
            Console.WriteLine("200");
        }
    }
}
