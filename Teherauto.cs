using System;
using System.Collections.Generic;
using System.Text;
using static FlottaApp.Jarmu;

namespace FlottaApp 
{
    internal class Teherauto : Jarmu
    {
        public double Teherbiras { get; set; }

        public Teherauto(double teherbiras, string rendszam, int alapar) :base(rendszam, alapar)
        {
            Teherbiras = teherbiras;
        }
        public override int Adokalkulacio(int alapar)
        { 
            return base.Adokalkulacio(alapar) + (int)(Teherbiras * 1000);
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Teherbírás: {Teherbiras} ";
        }

    }
}
