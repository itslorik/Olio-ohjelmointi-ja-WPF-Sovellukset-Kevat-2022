using System;
using System.Collections.Generic;
using System.Text;

namespace StatciEsimerkki
{
     static class Muuntaja
    {
        public static float KmToMiles(float km)
        {
            float mailiArvo = 0.62137f;
            return km * mailiArvo;
        }
    }
}
