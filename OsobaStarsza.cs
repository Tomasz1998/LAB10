using System;
using System.Collections.Generic;
using System.Text;

namespace LAB10
{
    public class OsobaStarsza
    {
        public bool ZwolnienieZOplaty { get; set; }
        public string NrLegitymacji { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZdjecia { get; set; }
        public (string NrLegitymacji, bool ZwolnienieZOplaty, DateTime DataUrodzenia, string AdresZdjecia) ZwrocWszystkieDane()
        {
            return (NrLegitymacji, ZwolnienieZOplaty, DataUrodzenia, AdresZdjecia);
        }
        public void Deconstruct(out string nrLegitymacji, out bool zwolnienie, out DateTime urodziny, out string zdjecie )
        {
            nrLegitymacji = NrLegitymacji;
            zwolnienie = ZwolnienieZOplaty;
            urodziny = DataUrodzenia;
            zdjecie = AdresZdjecia;
        }
        public void Deconstruct(out string nrLegitymacji, out string zdjecie)
        {
            nrLegitymacji = NrLegitymacji;
            zdjecie = AdresZdjecia;

        }
    }
}
