using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFormAuto1B
{
    class Auto
    {
        public string Nazev { get; set; }
        public int Cena { get; set; }

        public Auto(string nazev,int cena)
        {
            Nazev = nazev;
            Cena = cena;
        }

        public override string ToString()
        {
            return String.Format($"{Nazev}, {Cena}");
        }
    }
}
