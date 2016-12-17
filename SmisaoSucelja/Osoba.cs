using System;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public Osoba(string ime, DateTime datumRođenja, string mjestoRođenja)
        {
            Ime = ime;
            DatumRođenja = datumRođenja;
            MjestoRođenja = mjestoRođenja;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Ime, DatumRođenja.ToShortDateString(), MjestoRođenja);
        }

        public readonly string Ime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
