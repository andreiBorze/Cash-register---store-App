using Cash_register___store_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash_register___store_App
{
    class Bon : IBon
    {
        public string getDescriere(decimal SumaDePlata, string MetodaDePlata)
        {
            var message = $"Metoda de plata: {MetodaDePlata}. Suma: {SumaDePlata}";
            Console.WriteLine(message);
            return message;
        }

        public string getMetodaPlata(string MetodaDePlata)
        {
            var message = $"Metoda de plata: {MetodaDePlata}";
            Console.WriteLine(message);
            return message;
        }

        public decimal getSumaPlatita(decimal SumaDePlata, string MetodaDePlata)
        {
            var message = $"Suma platita: {SumaDePlata}";
            Console.WriteLine(message);
            return SumaDePlata;
        }
    }
}
