using System;
using System.Collections.Generic;
using System.Text;

namespace FlottaApp
{
    internal class Jarmu
    {
        public string Rendszam { get; set; }
        private static int osszesJarmuSzama { get; set; }
        public static int OsszesJarmuSzama { get; set; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get { return Alapar; }
            set
            {
                if (value <= 0)
                {
                    Alapar = 1000000;
                }
            }
        }
        public Jarmu(string rendszam, int alapar)
        {
            Rendszam = rendszam;
            Alapar = alapar;
            osszesJarmuSzama++;
        }
        public virtual int Adokalkulacio(int alapar)
        {
            return alapar * 50 / 100;
        }
        public override string ToString()
        {
            return $"{Alapar} Ft";
        }
    }
}
