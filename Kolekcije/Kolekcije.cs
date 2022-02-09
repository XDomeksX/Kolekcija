using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{
    internal class Kolekcije
    {
        string ime, prezime, rod, brkovi;
        int god;

        public Kolekcije(string ime, string prezime, int god, string rod, string brkovi)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.God = god;
            this.Rod = rod;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Rod { get => rod; set => rod = value; }
        public string Brkovi { get => brkovi; set => brkovi = value; }
        public int God { get => god; set => god = value; }

        public override string ToString()
        {
            string ispis = this.ime + "\t" + this.prezime + "\t" + this.god + "\t" + this.rod + "\t" + this.brkovi;
            return ispis;
        }
    }
}
