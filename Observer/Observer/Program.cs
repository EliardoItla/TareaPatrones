using State;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto();
            contexto.State = new StateDisponible();

            contexto.Solicitud();

            contexto.State = new StateSaturado();
            contexto.Solicitud();
            contexto.Solicitud();

            contexto.State = new StateSuperSaturado();
            contexto.Solicitud();
            contexto.Solicitud();

            contexto.State = new StateCaido();
            contexto.Solicitud();
            contexto.Solicitud();

            contexto.State = new StateDisponible();
            contexto.Solicitud();
            contexto.Solicitud();
        }
    }
}
