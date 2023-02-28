using System;

namespace Cash_register___store_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CasaDeMarcat casaDeMarcat = new CasaDeMarcat();
            var cardContactFull = new CardContactFull();
            var cardContactless = new CardContactLess();
            var telefonContactless = new PlataTelefon();

            // Realizam o plata cash
            casaDeMarcat.PlatesteCash(100);

            // Realizam o plata cu cardul contact-full
            casaDeMarcat.PlatesteCardFull(50, cardContactFull);

            // Realizam o plata cu cardul contactless
            casaDeMarcat.PlatesteCardLess(75, cardContactless);

            // Realizam o plata cu telefonul
            casaDeMarcat.PlatesteTelefon(90, telefonContactless);

            // Afisam bonurile de casa

            Console.ReadLine();
        }
    }
}
