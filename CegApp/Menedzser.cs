using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegApp
{
    public class Menedzser : Alkalmazott
    {
        public int Bonusz {  get; set; }

        public Menedzser(string nev, int alapber, int bonusz) : base(nev,alapber)
        {
            Bonusz = bonusz;
        }

        public override int FizetesSzamitas()
        {
            return Alapber+Bonusz;
        }
    }
}
