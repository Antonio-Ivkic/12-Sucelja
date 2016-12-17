using System;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public Osoba(string ime, DateTime datumRo�enja, string mjestoRo�enja)
        {
            Ime = ime;
            DatumRo�enja = datumRo�enja;
            MjestoRo�enja = mjestoRo�enja;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Ime, DatumRo�enja.ToShortDateString(), MjestoRo�enja);
        }

        public readonly string Ime;
        public readonly DateTime DatumRo�enja;
        public readonly string MjestoRo�enja;
    }
}
