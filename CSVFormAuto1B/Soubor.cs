using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVFormAuto1B
{
    class Soubor
    {
        //ukládat auta do seznamu - List
        //ukládat seznam aut do CSV souboru
        //načítat auta z CSV souboru
        //výpis všech aut na konzoli

        private List<Auto> Auta;
        private string soubor;  //název souboru

        //parametrický konstruktor
        public Soubor(string soubor)
        {
            this.soubor = soubor;
            Auta = new List<Auto>();
        }

        //metoda vytváří instanci třídy Auto a auto přidá do Listu
        public void PridejAuto(string nazev, int cena)
        {
            Auto noveauto = new Auto(nazev, cena);
            //přidání do Listu
            Auta.Add(noveauto);
        }
        //metoda uloz zajistí uložení celého seznamu Auta do csv souboru
        public void Uloz()
        {
            using (StreamWriter sw = new StreamWriter(soubor))
            {
                foreach (Auto a in Auta)
                {
                    string[] info = { a.Nazev, a.Cena.ToString() };//pole s 2 prvky - nazev,cena
                    string radek = String.Join(";", info);//spojeni prvku pole info středníkem - "Honda";200000
                    sw.WriteLine(radek);// zapis hodnoty radek do souboru
                }
                sw.Flush();
            }

        }

        //metoda Nacti zajistí načtení obsahu souboru do seznamu Auta
        public void Nacti()
        {
            Auta.Clear(); //vymazání obsahu seznamu Auta
            using (StreamReader sr = new StreamReader(soubor))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                    {
                    string[] info = s.Split(';');
                    PridejAuto(info[0], int.Parse(info[1]));
                
                }
            }
        }

        //metoda pro výpis všech aut ze seznamu na konzoli
        public void Vypis()
        {
            foreach (Auto a in Auta)
                Console.WriteLine(a.ToString());
        }

    }
}
