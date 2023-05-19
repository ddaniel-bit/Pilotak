using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotakOsztaly
{
    class Pilotak
    {
        string nev;
        string szuletesidatum;
        string nemzetiseg;
        int rajtszam;

        public Pilotak(string nev, string szuletesidatum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletesidatum = szuletesidatum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; }
        public string Szuletesidatum { get => szuletesidatum; }
        public string Nemzetiseg { get => nemzetiseg; }
        public int Rajtszam { get => rajtszam; }

    }
}
