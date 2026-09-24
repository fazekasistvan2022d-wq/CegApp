using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegApp
{
    public class Alkalmazott
    {
        public string Nev { get; set; }
        protected int Alapber { get; set; }
        
        public Alkalmazott(string nev, int alapber)
        {
            Nev = nev;
            Alapber = alapber;
        }

        public virtual int FizetesSzamitas()
        {
            return Alapber;
        }

        public override string ToString()
        {
            return $"Név:{Nev},Fizetés: {FizetesSzamitas()}";
        }
    }
}
