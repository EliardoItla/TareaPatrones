using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Contexto
    {
        private State state;

        public State State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        
        public void Solicitud()
        {
            state.Respuesta();
        }
    }
}
