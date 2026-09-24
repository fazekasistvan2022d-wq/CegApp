using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alkalmazott alkalmazott1 = new Alkalmazott("Kovács János",400000);
            Menedzser menedzser1 = new Menedzser("Nagy Anna", 600000, 200000);
            Console.WriteLine(alkalmazott1);
            Console.WriteLine(menedzser1);
        }
    }
}
