using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400132
{
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka };
        public State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu sedang terkunci");
        }

        public void PerubahanState(string perintah)
        {
            if (currentState == State.Terkunci && perintah == "BukaPintu")
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else if (currentState == State.Terbuka && perintah == "KunciPintu")
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                string status = (currentState == State.Terkunci) ? "Pintu terkunci" : "Pintu tidak terkunci";
                Console.WriteLine(status);
            }
        }
    }
}
