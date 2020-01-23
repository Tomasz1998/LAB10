using System;

namespace LAB10
{
    class Program
    {
        //static double ObliczCeneBiletu(object pasazer)
        //{


        //    switch (pasazer)
        //    {
        //        case Dziecko d:
        //            Console.WriteLine($"To jest dziecko ma zniszke {d.Znizka}");
        //            break;
        //        case OsobaStarsza os when os.ZwolnienieZOplaty:
        //            Console.WriteLine("to jest osoba starsza" + "ma darmowe przejazdy");
        //            break;
        //        case OsobaStarsza _:
        //            Console.WriteLine("to jest osoba starsza");
        //            break;
        //        case Rencista r when r.ZwolnienieZZaplaty:
        //            if (r.WaznoscRenty > DateTime.Now)
        //            {
        //                Console.WriteLine("rencista ma se rente i jest se zwolniony");
        //            }
        //            else
        //            {
        //                Console.WriteLine("placi typ");
        //            }
        //            break;
        //        case null:
        //            Console.WriteLine("nie wiem co to jest");
        //            break;
        //        default:
        //            Console.WriteLine("defolt");
        //            break;

        //    }
        //    return 0;


        //if (pasazer is Dziecko dziecko)
        //{
        //   // var dziecko = (Dziecko)pasazer;

        //    Console.WriteLine($"to jest dziecko, ma zniżke {dziecko.Znizka}");
        //}
        //else if (pasazer is OsobaStarsza oStarsza)
        //{
        //    Console.WriteLine("To jest osoba starsza");
        //    if (oStarsza.ZwolnienieZOplaty)
        //    {
        //        Console.WriteLine("ma darmowy przejazd");
        //    }
        //}
        //return 0;
        //}
        static void Main(string[] args)
        {
            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "1234567890",
                ZwolnienieZOplaty = true,
                DataUrodzenia = DateTime.Now.AddYears(-70),
                AdresZdjecia = "./images/photos/1234567890.jpg"
            };
            var (nrLegitymacji, zwolnienie, dataUr, zdjecie) = osoba;                                           
            var (numer, fotka) = osoba;
            var dziecko = new Dziecko()
            {
                DataUrodzenia = DateTime.Now.AddYears(-10)
                
            };
            var (dataurodzenia, klasa) = dziecko;
            Console.WriteLine(dataurodzenia.ToShortDateString() + " " + klasa);
            
            //(string legitka, bool znizka, DateTime DataUr, string fotka) = osoba.ZwrocWszystkieDane();
            //var (legitymacja, obnizka, dataUrodz, zdjęcie) = osoba.ZwrocWszystkieDane();
            //var temp = osoba.ZwrocWszystkieDane();
            //Console.WriteLine($"{temp.NrLegitymacji}");
            //(_, bool zwolnienie, DateTime data, string fotografia) = osoba.ZwrocWszystkieDane();







            //var pasazer = new ZwyklyPasazer();
            //var dziecko = new Dziecko() { Znizka = 0.5 };
            //var emeryt = new OsobaStarsza() { ZwolnienieZOplaty = true };
            //var rencista = new Rencista() { ZwolnienieZZaplaty = true, WaznoscRenty = new DateTime(2020, 1, 10) };
            //var rencista1 = new Rencista() { ZwolnienieZZaplaty = true, WaznoscRenty = new DateTime(2020, 8, 10) };
            //Console.WriteLine("Zwykły pasazer");
            //ObliczCeneBiletu(pasazer);
            //Console.WriteLine("Dziecko");
            //ObliczCeneBiletu(dziecko);
            //Console.WriteLine("Emeryt");
            //ObliczCeneBiletu(emeryt);
            //Console.WriteLine("Rencista1");
            //ObliczCeneBiletu(rencista);
            //Console.WriteLine("Rencista2");
            //ObliczCeneBiletu(rencista1);
            //Console.WriteLine("string");
            //ObliczCeneBiletu("pasazer");
            //Console.WriteLine("null");
            //ObliczCeneBiletu(null);
            //Console.ReadKey();
        }
    }
}
