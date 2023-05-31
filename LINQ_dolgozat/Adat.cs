using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_dolgozat
{
    class Adat
    {
        public string Ev;
        public string Nev;
        public string Vegyjel;
        public int Rendszam;
        public string Felfedezo;

        public Adat(string s){
            string[] darabok = s.Split(';');
            this.Ev = darabok[0];
            this.Nev = darabok[1];
            this.Vegyjel = darabok[2];
            this.Rendszam = Convert.ToInt32(darabok[3]);
            this.Felfedezo = darabok[4];
        
                }

    }
}
