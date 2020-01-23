using System;
using System.Collections.Generic;
using System.Text;

namespace LAB10
{
    public class Dziecko
    {
        public double Znizka { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public void Deconstruct(out DateTime dataUrodzenia, out string klasa)
        {
            dataUrodzenia = DataUrodzenia;
            klasa = "nie chodzi";
            if(DateTime.Now.Year - dataUrodzenia.Year >= 9 && DateTime.Now.Year - dataUrodzenia.Year <= 14)
            {
                klasa = "podstawowka";
            }
            else if (DateTime.Now.Year - dataUrodzenia.Year >= 15 && DateTime.Now.Year - dataUrodzenia.Year <= 19)
            {
                klasa = "technikum";
            }
            else if (DateTime.Now.Year - dataUrodzenia.Year >= 20)
            {
                klasa = "studia";
            }
        }
    }
}
